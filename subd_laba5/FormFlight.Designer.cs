
namespace subd_laba5
{
    partial class FormFlight
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIdPilot = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIdAirplane = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIdRoute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRouteId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(455, 227);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 39);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(455, 164);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(130, 39);
            this.buttonRef.TabIndex = 8;
            this.buttonRef.Text = "Изменить";
            this.buttonRef.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(455, 104);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 39);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(455, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 39);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 330);
            this.dataGridView1.TabIndex = 5;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(679, 43);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 15);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "Id:";
            // 
            // comboBoxId
            // 
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(728, 40);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(108, 23);
            this.comboBoxId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id пилота:";
            // 
            // comboBoxIdPilot
            // 
            this.comboBoxIdPilot.FormattingEnabled = true;
            this.comboBoxIdPilot.Location = new System.Drawing.Point(728, 92);
            this.comboBoxIdPilot.Name = "comboBoxIdPilot";
            this.comboBoxIdPilot.Size = new System.Drawing.Size(108, 23);
            this.comboBoxIdPilot.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id самолета:";
            // 
            // comboBoxIdAirplane
            // 
            this.comboBoxIdAirplane.FormattingEnabled = true;
            this.comboBoxIdAirplane.Location = new System.Drawing.Point(728, 134);
            this.comboBoxIdAirplane.Name = "comboBoxIdAirplane";
            this.comboBoxIdAirplane.Size = new System.Drawing.Size(108, 23);
            this.comboBoxIdAirplane.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id маршрута:";
            // 
            // comboBoxIdRoute
            // 
            this.comboBoxIdRoute.FormattingEnabled = true;
            this.comboBoxIdRoute.Location = new System.Drawing.Point(728, 180);
            this.comboBoxIdRoute.Name = "comboBoxIdRoute";
            this.comboBoxIdRoute.Size = new System.Drawing.Size(108, 23);
            this.comboBoxIdRoute.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id направления:";
            // 
            // comboBoxRouteId
            // 
            this.comboBoxRouteId.FormattingEnabled = true;
            this.comboBoxRouteId.Location = new System.Drawing.Point(728, 218);
            this.comboBoxRouteId.Name = "comboBoxRouteId";
            this.comboBoxRouteId.Size = new System.Drawing.Size(108, 23);
            this.comboBoxRouteId.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Количество занятых мест:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(786, 264);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(49, 23);
            this.textBoxCount.TabIndex = 23;
            // 
            // FormFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 380);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRouteId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxIdRoute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxIdAirplane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxIdPilot);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.comboBoxId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFlight";
            this.Text = "FormFlight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ComboBox comboBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIdPilot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIdAirplane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIdRoute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRouteId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}