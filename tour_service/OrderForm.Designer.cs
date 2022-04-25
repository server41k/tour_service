
namespace tour_service
{
    partial class OrderForm
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
            this.buttonOrder = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.docsOrderLabel = new System.Windows.Forms.Label();
            this.docsOrder = new System.Windows.Forms.TextBox();
            this.teamOrderLabel = new System.Windows.Forms.Label();
            this.teamOrder = new System.Windows.Forms.TextBox();
            this.dateOrderLabel = new System.Windows.Forms.Label();
            this.dateOrder = new System.Windows.Forms.TextBox();
            this.nameOrderLabel = new System.Windows.Forms.Label();
            this.nameOrder = new System.Windows.Forms.TextBox();
            this.numOrderLabel = new System.Windows.Forms.Label();
            this.numOrder = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Green;
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(49, 379);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(307, 45);
            this.buttonOrder.TabIndex = 5;
            this.buttonOrder.Text = "Сделать заказ";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.mainPanel.Controls.Add(this.docsOrderLabel);
            this.mainPanel.Controls.Add(this.docsOrder);
            this.mainPanel.Controls.Add(this.teamOrderLabel);
            this.mainPanel.Controls.Add(this.teamOrder);
            this.mainPanel.Controls.Add(this.dateOrderLabel);
            this.mainPanel.Controls.Add(this.dateOrder);
            this.mainPanel.Controls.Add(this.nameOrderLabel);
            this.mainPanel.Controls.Add(this.nameOrder);
            this.mainPanel.Controls.Add(this.numOrderLabel);
            this.mainPanel.Controls.Add(this.buttonOrder);
            this.mainPanel.Controls.Add(this.numOrder);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(429, 464);
            this.mainPanel.TabIndex = 2;
            // 
            // docsOrderLabel
            // 
            this.docsOrderLabel.AutoSize = true;
            this.docsOrderLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.docsOrderLabel.ForeColor = System.Drawing.Color.White;
            this.docsOrderLabel.Location = new System.Drawing.Point(8, 307);
            this.docsOrderLabel.Name = "docsOrderLabel";
            this.docsOrderLabel.Size = new System.Drawing.Size(152, 34);
            this.docsOrderLabel.TabIndex = 14;
            this.docsOrderLabel.Text = "Документы";
            // 
            // docsOrder
            // 
            this.docsOrder.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.docsOrder.Location = new System.Drawing.Point(200, 307);
            this.docsOrder.Multiline = true;
            this.docsOrder.Name = "docsOrder";
            this.docsOrder.Size = new System.Drawing.Size(178, 34);
            this.docsOrder.TabIndex = 13;
            // 
            // teamOrderLabel
            // 
            this.teamOrderLabel.AutoSize = true;
            this.teamOrderLabel.Font = new System.Drawing.Font("Impact", 12F);
            this.teamOrderLabel.ForeColor = System.Drawing.Color.White;
            this.teamOrderLabel.Location = new System.Drawing.Point(8, 267);
            this.teamOrderLabel.Name = "teamOrderLabel";
            this.teamOrderLabel.Size = new System.Drawing.Size(170, 25);
            this.teamOrderLabel.TabIndex = 12;
            this.teamOrderLabel.Text = "Сколько человек?";
            // 
            // teamOrder
            // 
            this.teamOrder.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.teamOrder.Location = new System.Drawing.Point(200, 267);
            this.teamOrder.Multiline = true;
            this.teamOrder.Name = "teamOrder";
            this.teamOrder.Size = new System.Drawing.Size(178, 34);
            this.teamOrder.TabIndex = 11;
            // 
            // dateOrderLabel
            // 
            this.dateOrderLabel.AutoSize = true;
            this.dateOrderLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.dateOrderLabel.ForeColor = System.Drawing.Color.White;
            this.dateOrderLabel.Location = new System.Drawing.Point(7, 227);
            this.dateOrderLabel.Name = "dateOrderLabel";
            this.dateOrderLabel.Size = new System.Drawing.Size(73, 34);
            this.dateOrderLabel.TabIndex = 10;
            this.dateOrderLabel.Text = "Дата";
            // 
            // dateOrder
            // 
            this.dateOrder.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateOrder.Location = new System.Drawing.Point(200, 227);
            this.dateOrder.Multiline = true;
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(178, 34);
            this.dateOrder.TabIndex = 9;
            // 
            // nameOrderLabel
            // 
            this.nameOrderLabel.AutoSize = true;
            this.nameOrderLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.nameOrderLabel.ForeColor = System.Drawing.Color.White;
            this.nameOrderLabel.Location = new System.Drawing.Point(7, 187);
            this.nameOrderLabel.Name = "nameOrderLabel";
            this.nameOrderLabel.Size = new System.Drawing.Size(62, 34);
            this.nameOrderLabel.TabIndex = 8;
            this.nameOrderLabel.Text = "Имя";
            // 
            // nameOrder
            // 
            this.nameOrder.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.nameOrder.Location = new System.Drawing.Point(200, 187);
            this.nameOrder.Multiline = true;
            this.nameOrder.Name = "nameOrder";
            this.nameOrder.Size = new System.Drawing.Size(178, 34);
            this.nameOrder.TabIndex = 7;
            // 
            // numOrderLabel
            // 
            this.numOrderLabel.AutoSize = true;
            this.numOrderLabel.Font = new System.Drawing.Font("Impact", 16F);
            this.numOrderLabel.ForeColor = System.Drawing.Color.White;
            this.numOrderLabel.Location = new System.Drawing.Point(8, 147);
            this.numOrderLabel.Name = "numOrderLabel";
            this.numOrderLabel.Size = new System.Drawing.Size(171, 34);
            this.numOrderLabel.TabIndex = 6;
            this.numOrderLabel.Text = "Номер услуги";
            // 
            // numOrder
            // 
            this.numOrder.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.numOrder.Location = new System.Drawing.Point(200, 147);
            this.numOrder.Multiline = true;
            this.numOrder.Name = "numOrder";
            this.numOrder.Size = new System.Drawing.Size(178, 34);
            this.numOrder.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 100);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(399, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 36);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 464);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox numOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numOrderLabel;
        private System.Windows.Forms.Label docsOrderLabel;
        private System.Windows.Forms.TextBox docsOrder;
        private System.Windows.Forms.Label teamOrderLabel;
        private System.Windows.Forms.TextBox teamOrder;
        private System.Windows.Forms.Label dateOrderLabel;
        private System.Windows.Forms.TextBox dateOrder;
        private System.Windows.Forms.Label nameOrderLabel;
        private System.Windows.Forms.TextBox nameOrder;
    }
}