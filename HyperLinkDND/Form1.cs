using System.Diagnostics;

namespace HyperLinkDND
{
    public partial class Form1 : Form
    {

       
        private System.Windows.Forms.LinkLabel Artificer2024;
        private System.Windows.Forms.LinkLabel barbarian2024;
        private System.Windows.Forms.LinkLabel Bard2024;
        private System.Windows.Forms.LinkLabel Cleric2024;
        private System.Windows.Forms.LinkLabel Druid2024;
        private System.Windows.Forms.LinkLabel Fighter2024;
        private System.Windows.Forms.LinkLabel Monk2024;
        private System.Windows.Forms.LinkLabel Paladin2024;
        private System.Windows.Forms.LinkLabel Ranger2024;
        private System.Windows.Forms.LinkLabel Rogue2024;
        private System.Windows.Forms.LinkLabel Sorcerer2024;
        private System.Windows.Forms.LinkLabel Warlock2024;
        private System.Windows.Forms.LinkLabel Wizard2024;

        private System.Windows.Forms.LinkLabel Artificer;
        private System.Windows.Forms.LinkLabel barbarian;
        private System.Windows.Forms.LinkLabel Bard;
        private System.Windows.Forms.LinkLabel Cleric;
        private System.Windows.Forms.LinkLabel Druid;
        private System.Windows.Forms.LinkLabel Fighter;
        private System.Windows.Forms.LinkLabel Monk;
        private System.Windows.Forms.LinkLabel Paladin;
        private System.Windows.Forms.LinkLabel Ranger;
        private System.Windows.Forms.LinkLabel Rogue;
        private System.Windows.Forms.LinkLabel Sorcerer;
        private System.Windows.Forms.LinkLabel Warlock;
        private System.Windows.Forms.LinkLabel Wizard;



        private System.Windows.Forms.TabControl DNDTabs;
        private System.Windows.Forms.TabPage DND2024;
        private System.Windows.Forms.TabPage DND2014;

        public Form1()
        {
            InitializeComponent();

            this.Tag = "Dungeons and Dragons 5.5e";

            DNDTabs = new System.Windows.Forms.TabControl();
            DNDTabs.Location = new System.Drawing.Point(0, 0);
            DNDTabs.Size = new System.Drawing.Size(750, 500);

            
            this.DND2024 = new System.Windows.Forms.TabPage();
            this.DND2024.TabIndex = 0;
            this.DND2024.Text = "2024";

            this.DND2014 = new System.Windows.Forms.TabPage();
            this.DND2014.TabIndex = 1;
            this.DND2014.Text = "2014";



         

            this.DND2024.Controls.AddRange(Classes2024());
            this.DND2014.Controls.AddRange(Classes2014());
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.DNDTabs.Controls.AddRange(new System.Windows.Forms.Control[] {DND2024, DND2014});
            //this.Controls.AddRange(new System.Windows.Forms.Control[] {DNDTabs, this.Artificer, this.barbarian, this.Bard, this.Cleric, this.Druid, this.Fighter, this.Monk, this.Paladin, this.Ranger, this.Rogue, this.Sorcerer, this.Warlock, this.Wizard });
            this.Controls.AddRange(new System.Windows.Forms.Control[] {DNDTabs});
        }

        private System.Windows.Forms.Control[] Classes2014()
        {

            /*Artificer class*/
            this.Artificer = new System.Windows.Forms.LinkLabel();
            this.Artificer.Location = new System.Drawing.Point(34, 50);


            // Specify that the size should be automatically determined by the content.
            this.Artificer.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Artificer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);

            // Set the text for the LinkLabel.
            this.Artificer.Text = "Artificer";

            /*Barbarian class*/
            this.barbarian = new System.Windows.Forms.LinkLabel();
            this.barbarian.Location = new System.Drawing.Point(34, 75);


            // Specify that the size should be automatically determined by the content.
            this.barbarian.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.barbarian.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

            // Set the text for the LinkLabel.
            this.barbarian.Text = "Barbarian";


            /*Bard class*/
            this.Bard = new System.Windows.Forms.LinkLabel();
            this.Bard.Location = new System.Drawing.Point(34, 100);


            // Specify that the size should be automatically determined by the content.
            this.Bard.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Bard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);

            // Set the text for the LinkLabel.
            this.Bard.Text = "Bard";

            /*cleric class*/
            this.Cleric = new System.Windows.Forms.LinkLabel();
            this.Cleric.Location = new System.Drawing.Point(34, 125);


            // Specify that the size should be automatically determined by the content.
            this.Cleric.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Cleric.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);

            // Set the text for the LinkLabel.
            this.Cleric.Text = "Cleric";


            /*Druid class*/
            this.Druid = new System.Windows.Forms.LinkLabel();
            this.Druid.Location = new System.Drawing.Point(34, 150);


            // Specify that the size should be automatically determined by the content.
            this.Druid.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Druid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);

            // Set the text for the LinkLabel.
            this.Druid.Text = "Druid";

            /*Fighter class*/
            this.Fighter = new System.Windows.Forms.LinkLabel();
            this.Fighter.Location = new System.Drawing.Point(34, 175);


            // Specify that the size should be automatically determined by the content.
            this.Fighter.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Fighter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);

            // Set the text for the LinkLabel.
            this.Fighter.Text = "Fighter";

            /*Monk class*/
            this.Monk = new System.Windows.Forms.LinkLabel();
            this.Monk.Location = new System.Drawing.Point(34, 200);


            // Specify that the size should be automatically determined by the content.
            this.Monk.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Monk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);

            // Set the text for the LinkLabel.
            this.Monk.Text = "Monk";


            /*Paladin class*/
            this.Paladin = new System.Windows.Forms.LinkLabel();
            this.Paladin.Location = new System.Drawing.Point(34, 225);


            // Specify that the size should be automatically determined by the content.
            this.Paladin.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Paladin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);

            // Set the text for the LinkLabel.
            this.Paladin.Text = "Paladin";

            /*Ranger class*/
            this.Ranger = new System.Windows.Forms.LinkLabel();
            this.Ranger.Location = new System.Drawing.Point(34, 250);


            // Specify that the size should be automatically determined by the content.
            this.Ranger.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Ranger.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);

            // Set the text for the LinkLabel.
            this.Ranger.Text = "Ranger";

            /*Rogue class*/
            this.Rogue = new System.Windows.Forms.LinkLabel();
            this.Rogue.Location = new System.Drawing.Point(34, 275);


            // Specify that the size should be automatically determined by the content.
            this.Rogue.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Rogue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);

            // Set the text for the LinkLabel.
            this.Rogue.Text = "Rogue";

            /*Sorcerer class*/
            this.Sorcerer = new System.Windows.Forms.LinkLabel();
            this.Sorcerer.Location = new System.Drawing.Point(34, 300);


            // Specify that the size should be automatically determined by the content.
            this.Sorcerer.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Sorcerer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel11_LinkClicked);

            // Set the text for the LinkLabel.
            this.Sorcerer.Text = "Sorcerer";

            /*Warlock class*/
            this.Warlock = new System.Windows.Forms.LinkLabel();
            this.Warlock.Location = new System.Drawing.Point(34, 325);


            // Specify that the size should be automatically determined by the content.
            this.Warlock.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Warlock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel12_LinkClicked);

            // Set the text for the LinkLabel.
            this.Warlock.Text = "Warlock";

            /*Wizard class*/
            this.Wizard = new System.Windows.Forms.LinkLabel();
            this.Wizard.Location = new System.Drawing.Point(34, 350);


            // Specify that the size should be automatically determined by the content.
            this.Wizard.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Wizard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel13_LinkClicked);

            // Set the text for the LinkLabel.
            this.Wizard.Text = "Wizard";

            return new System.Windows.Forms.Control[] { this.Artificer, this.barbarian, this.Bard, this.Cleric, this.Druid, this.Fighter, this.Monk, this.Paladin, this.Ranger, this.Rogue, this.Sorcerer, this.Warlock, this.Wizard };

        }

        private System.Windows.Forms.Control[] Classes2024()
        {

            /*Artificer class*/
            this.Artificer2024 = new System.Windows.Forms.LinkLabel();
            this.Artificer2024.Location = new System.Drawing.Point(34, 50);


            // Specify that the size should be automatically determined by the content.
            this.Artificer2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Artificer2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);

            // Set the text for the LinkLabel.
            this.Artificer2024.Text = "Artificer";

            /*Barbarian class*/
            this.barbarian2024 = new System.Windows.Forms.LinkLabel();
            this.barbarian2024.Location = new System.Drawing.Point(34, 75);


            // Specify that the size should be automatically determined by the content.
            this.barbarian2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.barbarian2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

            // Set the text for the LinkLabel.
            this.barbarian2024.Text = "Barbarian";


            /*Bard class*/
            this.Bard2024 = new System.Windows.Forms.LinkLabel();
            this.Bard2024.Location = new System.Drawing.Point(34, 100);


            // Specify that the size should be automatically determined by the content.
            this.Bard2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Bard2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);

            // Set the text for the LinkLabel.
            this.Bard2024.Text = "Bard";

            /*cleric class*/
            this.Cleric2024 = new System.Windows.Forms.LinkLabel();
            this.Cleric2024.Location = new System.Drawing.Point(34, 125);


            // Specify that the size should be automatically determined by the content.
            this.Cleric2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Cleric2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);

            // Set the text for the LinkLabel.
            this.Cleric2024.Text = "Cleric";


            /*Druid class*/
            this.Druid2024 = new System.Windows.Forms.LinkLabel();
            this.Druid2024.Location = new System.Drawing.Point(34, 150);


            // Specify that the size should be automatically determined by the content.
            this.Druid2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Druid2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);

            // Set the text for the LinkLabel.
            this.Druid2024.Text = "Druid";

            /*Fighter class*/
            this.Fighter2024 = new System.Windows.Forms.LinkLabel();
            this.Fighter2024.Location = new System.Drawing.Point(34, 175);


            // Specify that the size should be automatically determined by the content.
            this.Fighter2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Fighter2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);

            // Set the text for the LinkLabel.
            this.Fighter2024.Text = "Fighter";

            /*Monk class*/
            this.Monk2024 = new System.Windows.Forms.LinkLabel();
            this.Monk2024.Location = new System.Drawing.Point(34, 200);


            // Specify that the size should be automatically determined by the content.
            this.Monk2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Monk2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);

            // Set the text for the LinkLabel.
            this.Monk2024.Text = "Monk";


            /*Paladin class*/
            this.Paladin2024 = new System.Windows.Forms.LinkLabel();
            this.Paladin2024.Location = new System.Drawing.Point(34, 225);


            // Specify that the size should be automatically determined by the content.
            this.Paladin2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Paladin2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);

            // Set the text for the LinkLabel.
            this.Paladin2024.Text = "Paladin";

            /*Ranger class*/
            this.Ranger2024 = new System.Windows.Forms.LinkLabel();
            this.Ranger2024.Location = new System.Drawing.Point(34, 250);


            // Specify that the size should be automatically determined by the content.
            this.Ranger2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Ranger2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);

            // Set the text for the LinkLabel.
            this.Ranger2024.Text = "Ranger";

            /*Rogue class*/
            this.Rogue2024 = new System.Windows.Forms.LinkLabel();
            this.Rogue2024.Location = new System.Drawing.Point(34, 275);


            // Specify that the size should be automatically determined by the content.
            this.Rogue2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Rogue2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);

            // Set the text for the LinkLabel.
            this.Rogue2024.Text = "Rogue";

            /*Sorcerer class*/
            this.Sorcerer2024 = new System.Windows.Forms.LinkLabel();
            this.Sorcerer2024.Location = new System.Drawing.Point(34, 300);


            // Specify that the size should be automatically determined by the content.
            this.Sorcerer2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Sorcerer2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel11_LinkClicked);

            // Set the text for the LinkLabel.
            this.Sorcerer2024.Text = "Sorcerer";

            /*Warlock class*/
            this.Warlock2024 = new System.Windows.Forms.LinkLabel();
            this.Warlock2024.Location = new System.Drawing.Point(34, 325);


            // Specify that the size should be automatically determined by the content.
            this.Warlock2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Warlock2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel12_LinkClicked);

            // Set the text for the LinkLabel.
            this.Warlock2024.Text = "Warlock";

            /*Wizard class*/
            this.Wizard2024 = new System.Windows.Forms.LinkLabel();
            this.Wizard2024.Location = new System.Drawing.Point(34, 350);


            // Specify that the size should be automatically determined by the content.
            this.Wizard2024.AutoSize = true;

            // Add an event handler to do something when the links are clicked.
            this.Wizard2024.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel13_LinkClicked);

            // Set the text for the LinkLabel.
            this.Wizard2024.Text = "Wizard";

            return new System.Windows.Forms.Control[] { this.Artificer2024, this.barbarian2024, this.Bard2024, this.Cleric2024, this.Druid2024, this.Fighter2024, this.Monk2024, this.Paladin2024, this.Ranger2024, this.Rogue2024, this.Sorcerer2024, this.Warlock2024, this.Wizard2024 };

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/barbarian:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/barbarian", 
                    UseShellExecute = true
                });
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/artificer:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/artificer",
                    UseShellExecute = true
                });
            }

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/bard:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/bard",
                    UseShellExecute = true
                });
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/cleric:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/cleric",
                    UseShellExecute = true
                });
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/druid:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/druid",
                    UseShellExecute = true
                });
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/fighter:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/fighter",
                    UseShellExecute = true
                });
            }
        }
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/monk:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/monk",
                    UseShellExecute = true
                });
            }
        }
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/paladin:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/paladin",
                    UseShellExecute = true
                });
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/ranger:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/ranger",
                    UseShellExecute = true
                });
            }
        }
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/rogue:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/rogue",
                    UseShellExecute = true
                });
            }
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/sorcerer:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/sorcerer",
                    UseShellExecute = true
                });
            }
        }
        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/warlock:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/warlock",
                    UseShellExecute = true
                });
            }
        }
        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DNDTabs.SelectedTab == DND2024)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {

                    FileName = "https://dnd2024.wikidot.com/wizard:main",
                    UseShellExecute = true
                });
            }
            else if (DNDTabs.SelectedTab == DND2014)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://dnd5e.wikidot.com/wizard",
                    UseShellExecute = true
                });
            }
        }
    }
}
