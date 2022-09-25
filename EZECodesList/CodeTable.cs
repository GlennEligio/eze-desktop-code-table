using EZECodesList.ADO.NETModels;
using EZECodesList.Dto;
using EZECodesList.Repository;
using GSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = EZECodesList.ADO.NETModels.Message;

namespace EZECodesList
{
    public partial class CodeTable : MetroFramework.Forms.MetroForm
    {
        private MessageRepository messageRepository;
        private ProfessorRepository profRepository;

        public CodeTable()
        {
            InitializeComponent();
        }

        private void CodeTable_Load(object sender, EventArgs e)
        {
            messageRepository = MessageRepository.getInstance();
            profRepository = ProfessorRepository.getInstance();
            populateProfessorList();
            btnPollCode.PerformClick();
        }

        private void btnSearchCode_Click(object sender, EventArgs e)
        {
            timerCodePoll.Stop();
            string profNumber = cboProf.SelectedValue.ToString();
            DateTime dateTime = dtSearch.Value.Date;
            List<Message> messages = messageRepository.getMessagesByDateAndSender(dateTime, profNumber);
            populateCodeGrid(messages);
        }

        private void btnPollCode_Click(object sender, EventArgs e)
        {
            if (timerCodePoll == null || timerCodePoll.Enabled == false)
            {
                timerCodePoll.Start();
            }
        }

        private void codeGrid_SelectionChanged(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            // updates the IsSeen of the Message
            foreach (DataGridViewRow row in codeGrid.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                ids.Add(id);
            }
            messageRepository.updateIsSeenMessageById(ids);
            codeGrid.Refresh();
        }

        private void timerCodePoll_Tick(object sender, EventArgs e)
        {
            List<Message> messages = messageRepository.getMessagesByDate(DateTime.Now);
            populateCodeGrid(messages);
        }

        private void populateCodeGrid(List<Message> messages)
        {
            List<MessageDto> messageDtos = new List<MessageDto>();
            if (messages.Count > 0)
            {
                foreach (Message m in messages)
                {
                    MessageDto messageDto = new MessageDto();
                    messageDto.Code = m.Code;
                    messageDto.Id = m.Id;
                    messageDto.IsSeen = m.IsSeen.Value;
                    messageDto.Professor = profRepository.getProfessorByContactNumber(m.Sender).Name;
                    messageDto.DateReceived = m.DateReceived;
                    messageDtos.Add(messageDto);
                }
            }

            BindingSource bi = new BindingSource();
            bi.DataSource = messages;
            codeGrid.DataSource = bi;
            codeGrid.Refresh();

        }

        private void populateProfessorList()
        {
            List<Professor> professors = profRepository.getProfessors();
            cboProf.DataSource = professors;
            cboProf.ValueMember = "Contact_Number";
            cboProf.DisplayMember = "Name";
        }

    }
}
