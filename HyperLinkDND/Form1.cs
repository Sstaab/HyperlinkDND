using System.Diagnostics;

namespace HyperLinkDND
{
    public partial class Form1 : Form
    {

       
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

        public Form1()
        {
            InitializeComponent();

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












            //Creates the canvas and adds the link label to it.
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.Artificer, this.barbarian, this.Bard, this.Cleric, this.Druid, this.Fighter, this.Monk, this.Paladin, this.Ranger, this.Rogue, this.Sorcerer, this.Warlock, this.Wizard });

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/barbarian:main", // Replace with your URL
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/artificer:main", // Replace with your URL
                UseShellExecute = true
            });

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/bard:main", // Replace with your URL
                UseShellExecute = true
            });

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/cleric:main", // Replace with your URL
                UseShellExecute = true
            });

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/druid:main", // Replace with your URL
                UseShellExecute = true
            });

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/fighter:main", // Replace with your URL
                UseShellExecute = true
            });

        }
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/monk:main", // Replace with your URL
                UseShellExecute = true
            });

        }
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/paladin:main", // Replace with your URL
                UseShellExecute = true
            });

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/ranger:main", // Replace with your URL
                UseShellExecute = true
            });

        }
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/rogue:main", // Replace with your URL
                UseShellExecute = true
            });

        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/sorcerer:main", // Replace with your URL
                UseShellExecute = true
            });

        }
        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/warlock:main", // Replace with your URL
                UseShellExecute = true
            });

        }
        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fixes the Win32Exception by using ShellExecute
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://dnd2024.wikidot.com/wizard:main", // Replace with your URL
                UseShellExecute = true
            });

        }
    }
}
