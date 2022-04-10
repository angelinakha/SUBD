
namespace subd_laba5
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAirplane = new System.Windows.Forms.Button();
            this.buttonFlight = new System.Windows.Forms.Button();
            this.buttonRoute = new System.Windows.Forms.Button();
            this.buttonPilot = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAirplane
            // 
            this.buttonAirplane.Location = new System.Drawing.Point(21, 86);
            this.buttonAirplane.Name = "buttonAirplane";
            this.buttonAirplane.Size = new System.Drawing.Size(114, 31);
            this.buttonAirplane.TabIndex = 0;
            this.buttonAirplane.Text = "Самолеты";
            this.buttonAirplane.UseVisualStyleBackColor = true;
            this.buttonAirplane.Click += new System.EventHandler(this.buttonAirplane_Click);
            // 
            // buttonFlight
            // 
            this.buttonFlight.Location = new System.Drawing.Point(228, 29);
            this.buttonFlight.Name = "buttonFlight";
            this.buttonFlight.Size = new System.Drawing.Size(114, 31);
            this.buttonFlight.TabIndex = 1;
            this.buttonFlight.Text = "Рейсы";
            this.buttonFlight.UseVisualStyleBackColor = true;
            this.buttonFlight.Click += new System.EventHandler(this.buttonFlight_Click);
            // 
            // buttonRoute
            // 
            this.buttonRoute.Location = new System.Drawing.Point(154, 86);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(114, 31);
            this.buttonRoute.TabIndex = 2;
            this.buttonRoute.Text = "Маршруты";
            this.buttonRoute.UseVisualStyleBackColor = true;
            this.buttonRoute.Click += new System.EventHandler(this.buttonRoute_Click);
            // 
            // buttonPilot
            // 
            this.buttonPilot.Location = new System.Drawing.Point(293, 86);
            this.buttonPilot.Name = "buttonPilot";
            this.buttonPilot.Size = new System.Drawing.Size(114, 31);
            this.buttonPilot.TabIndex = 3;
            this.buttonPilot.Text = "Пилоты";
            this.buttonPilot.UseVisualStyleBackColor = true;
            this.buttonPilot.Click += new System.EventHandler(this.buttonPilot_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.Location = new System.Drawing.Point(424, 86);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(114, 31);
            this.buttonTicket.TabIndex = 4;
            this.buttonTicket.Text = "Билеты";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 156);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.buttonPilot);
            this.Controls.Add(this.buttonRoute);
            this.Controls.Add(this.buttonFlight);
            this.Controls.Add(this.buttonAirplane);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAirplane;
        private System.Windows.Forms.Button buttonFlight;
        private System.Windows.Forms.Button buttonRoute;
        private System.Windows.Forms.Button buttonPilot;
        private System.Windows.Forms.Button buttonTicket;
    }
}