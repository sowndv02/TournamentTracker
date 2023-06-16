﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerUI;

namespace TournamentTracker
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;   
            //CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Borrow" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Smith" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";
            teamMemberListBox.DataSource = null;

            teamMemberListBox.DataSource = selectedTeamMembers;
            teamMemberListBox.DisplayMember = "FullName";


        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.PhoneNumber = phoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                phoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields!");
            }

        }

        private bool ValidateForm()
        {
            // TODO - Add Validation to the form;
            if (firstNameValue.Text.Length == 0) return false;

            if (lastNameValue.Text.Length == 0) return false;

            if (emailValue.Text.Length == 0) return false;

            if (phoneValue.Text.Length == 0) return false;

            return true;
        }

        private bool ValidateTeamName()
        {
            // TODO - Add Validation to the TeamName;
            if (teamNamentNameValue.Text.Length == 0) return false;

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = selectTeamMemberDropDown.SelectedItem as PersonModel;
            if (person != null)
            {
                availableTeamMembers.Remove(person);
                selectedTeamMembers.Add(person);

                WireUpLists();
            }


        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel person = teamMemberListBox.SelectedItem as PersonModel;

            if (person != null)
            {
                selectedTeamMembers.Remove(person);
                availableTeamMembers.Add(person);

                WireUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            if (ValidateTeamName())
            {
                t.TeamName = teamNamentNameValue.Text;
                t.TeamMembers = selectedTeamMembers;

                GlobalConfig.Connection.CreateTeam(t);
                callingForm.TeamCompelete(t);
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields!");
            }
            
        }
    }
}