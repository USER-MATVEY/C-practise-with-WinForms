namespace practise_work_10
{
    partial class house_creation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.House_name = new System.Windows.Forms.TextBox();
            this.floors_count = new System.Windows.Forms.TextBox();
            this.paradnaya_count = new System.Windows.Forms.TextBox();
            this.apps_on_floor_count = new System.Windows.Forms.TextBox();
            this.name_of_the_house = new System.Windows.Forms.Label();
            this.floor_count = new System.Windows.Forms.Label();
            this.padick_count = new System.Windows.Forms.Label();
            this.appartment_on_floor = new System.Windows.Forms.Label();
            this.Create_house = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // House_name
            // 
            this.House_name.Location = new System.Drawing.Point(236, 46);
            this.House_name.Name = "House_name";
            this.House_name.Size = new System.Drawing.Size(177, 26);
            this.House_name.TabIndex = 0;
            // 
            // floors_count
            // 
            this.floors_count.Location = new System.Drawing.Point(236, 96);
            this.floors_count.Name = "floors_count";
            this.floors_count.Size = new System.Drawing.Size(100, 26);
            this.floors_count.TabIndex = 1;
            // 
            // paradnaya_count
            // 
            this.paradnaya_count.Location = new System.Drawing.Point(236, 146);
            this.paradnaya_count.Name = "paradnaya_count";
            this.paradnaya_count.Size = new System.Drawing.Size(100, 26);
            this.paradnaya_count.TabIndex = 2;
            // 
            // apps_on_floor_count
            // 
            this.apps_on_floor_count.Location = new System.Drawing.Point(294, 193);
            this.apps_on_floor_count.Name = "apps_on_floor_count";
            this.apps_on_floor_count.Size = new System.Drawing.Size(100, 26);
            this.apps_on_floor_count.TabIndex = 3;
            // 
            // name_of_the_house
            // 
            this.name_of_the_house.AutoSize = true;
            this.name_of_the_house.Location = new System.Drawing.Point(97, 49);
            this.name_of_the_house.Name = "name_of_the_house";
            this.name_of_the_house.Size = new System.Drawing.Size(103, 20);
            this.name_of_the_house.TabIndex = 4;
            this.name_of_the_house.Text = "Имя здания:";
            // 
            // floor_count
            // 
            this.floor_count.AutoSize = true;
            this.floor_count.Location = new System.Drawing.Point(84, 99);
            this.floor_count.Name = "floor_count";
            this.floor_count.Size = new System.Drawing.Size(125, 20);
            this.floor_count.TabIndex = 5;
            this.floor_count.Text = "Кол-во этажей:";
            // 
            // padick_count
            // 
            this.padick_count.AutoSize = true;
            this.padick_count.Location = new System.Drawing.Point(66, 149);
            this.padick_count.Name = "padick_count";
            this.padick_count.Size = new System.Drawing.Size(155, 20);
            this.padick_count.TabIndex = 6;
            this.padick_count.Text = "Кол-во подъездов:";
            // 
            // appartment_on_floor
            // 
            this.appartment_on_floor.AutoSize = true;
            this.appartment_on_floor.Location = new System.Drawing.Point(21, 196);
            this.appartment_on_floor.Name = "appartment_on_floor";
            this.appartment_on_floor.Size = new System.Drawing.Size(267, 20);
            this.appartment_on_floor.TabIndex = 7;
            this.appartment_on_floor.Text = "Кол-во квартир на каждом этаже:";
            // 
            // Create_house
            // 
            this.Create_house.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Create_house.Location = new System.Drawing.Point(413, 96);
            this.Create_house.Name = "Create_house";
            this.Create_house.Size = new System.Drawing.Size(204, 60);
            this.Create_house.TabIndex = 8;
            this.Create_house.Text = "Построить дом!!";
            this.Create_house.UseVisualStyleBackColor = false;
            this.Create_house.Click += new System.EventHandler(this.Create_house_Click);
            // 
            // house_creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.Create_house);
            this.Controls.Add(this.appartment_on_floor);
            this.Controls.Add(this.padick_count);
            this.Controls.Add(this.floor_count);
            this.Controls.Add(this.name_of_the_house);
            this.Controls.Add(this.apps_on_floor_count);
            this.Controls.Add(this.paradnaya_count);
            this.Controls.Add(this.floors_count);
            this.Controls.Add(this.House_name);
            this.Name = "house_creation";
            this.Text = "Domick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox House_name;
        private System.Windows.Forms.TextBox floors_count;
        private System.Windows.Forms.TextBox paradnaya_count;
        private System.Windows.Forms.TextBox apps_on_floor_count;
        private System.Windows.Forms.Label name_of_the_house;
        private System.Windows.Forms.Label floor_count;
        private System.Windows.Forms.Label padick_count;
        private System.Windows.Forms.Label appartment_on_floor;
        private System.Windows.Forms.Button Create_house;
    }
}

