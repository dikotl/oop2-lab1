namespace Task5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 190);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            // 
            // opacity_button
            // 
            this.opacity_button = new System.Windows.Forms.Button();
            this.opacity_button.Location = new System.Drawing.Point(20, 20);
            this.opacity_button.Name = "opacity_button";
            this.opacity_button.Size = new System.Drawing.Size(100, 30);
            this.opacity_button.TabIndex = 0;
            this.opacity_button.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.opacity_button.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.opacity_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opacity_button.Text = "Прозорість";
            this.opacity_button.Click += new System.EventHandler(this.OnOpacityButtonClicked);
            this.Controls.Add(this.opacity_button);
            // 
            // color_button
            // 
            this.color_button = new System.Windows.Forms.Button();
            this.color_button.Location = new System.Drawing.Point(130, 20);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(100, 30);
            this.color_button.TabIndex = 0;
            this.color_button.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.color_button.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.color_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_button.Text = "Колір тла";
            this.color_button.Click += new System.EventHandler(this.OnColorButtonClicked);
            this.Controls.Add(this.color_button);
            // 
            // hello_world_button
            // 
            this.hello_world_button = new System.Windows.Forms.Button();
            this.hello_world_button.Location = new System.Drawing.Point(240, 20);
            this.hello_world_button.Name = "hello_world_button";
            this.hello_world_button.Size = new System.Drawing.Size(100, 30);
            this.hello_world_button.TabIndex = 0;
            this.hello_world_button.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.hello_world_button.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.hello_world_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hello_world_button.Text = "Hello, World!";
            this.hello_world_button.Click += new System.EventHandler(this.OnHelloWorldButtonClicked);
            this.Controls.Add(this.hello_world_button);
            // 
            // super_mega_button
            // 
            this.super_mega_button = new System.Windows.Forms.Button();
            this.super_mega_button.Location = new System.Drawing.Point(350, 20);
            this.super_mega_button.Name = "super_mega_button";
            this.super_mega_button.Size = new System.Drawing.Size(210, 150);
            this.super_mega_button.TabIndex = 0;
            this.super_mega_button.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.super_mega_button.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.super_mega_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.super_mega_button.Text = "Супер-Мега-Кнопка";
            this.super_mega_button.Click += new System.EventHandler(this.OnSuperMegaButtonClicked);
            this.Controls.Add(this.super_mega_button);
            // 
            // opacity_checkbox
            // 
            this.opacity_checkbox = new System.Windows.Forms.CheckBox();
            this.opacity_checkbox.Location = new System.Drawing.Point(20, 60);
            this.opacity_checkbox.Name = "opacity_checkbox";
            this.opacity_checkbox.Size = new System.Drawing.Size(320, 30);
            this.opacity_checkbox.TabIndex = 0;
            this.opacity_checkbox.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.opacity_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.opacity_checkbox.Checked = false;
            this.opacity_checkbox.UseVisualStyleBackColor = false;
            this.opacity_checkbox.Text = "«Супер-Мега-Кнопка» як «Прозорість»";
            this.opacity_checkbox.CheckedChanged += new System.EventHandler(this.OnOpacityCheckboxChanged);
            this.Controls.Add(this.opacity_checkbox);
            // 
            // color_checkbox
            // 
            this.color_checkbox = new System.Windows.Forms.CheckBox();
            this.color_checkbox.Location = new System.Drawing.Point(20, 100);
            this.color_checkbox.Name = "color_checkbox";
            this.color_checkbox.Size = new System.Drawing.Size(320, 30);
            this.color_checkbox.TabIndex = 0;
            this.color_checkbox.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.color_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.color_checkbox.Checked = false;
            this.color_checkbox.UseVisualStyleBackColor = false;
            this.color_checkbox.Text = "«Супер-Мега-Кнопка» як «Колір тла»";
            this.color_checkbox.CheckedChanged += new System.EventHandler(this.OnColorCheckboxChanged);
            this.Controls.Add(this.color_checkbox);
            // 
            // hello_world_checkbox
            // 
            this.hello_world_checkbox = new System.Windows.Forms.CheckBox();
            this.hello_world_checkbox.Location = new System.Drawing.Point(20, 140);
            this.hello_world_checkbox.Name = "hello_world_checkbox";
            this.hello_world_checkbox.Size = new System.Drawing.Size(320, 30);
            this.hello_world_checkbox.TabIndex = 0;
            this.hello_world_checkbox.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.hello_world_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.hello_world_checkbox.Checked = false;
            this.hello_world_checkbox.UseVisualStyleBackColor = false;
            this.hello_world_checkbox.Text = "«Супер-Мега-Кнопка» як «Hello, World!»";
            this.hello_world_checkbox.CheckedChanged += new System.EventHandler(this.OnHelloWorldCheckboxChanged);
            this.Controls.Add(this.hello_world_checkbox);
            // 
            // Form controls collection
            // 
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.opacity_button,
                this.color_button,
                this.hello_world_button,
                this.opacity_checkbox,
                this.color_checkbox,
                this.hello_world_checkbox,
                this.super_mega_button
            });
            this.ResumeLayout(false);
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.Button opacity_button;
        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.Button hello_world_button;
        private System.Windows.Forms.CheckBox opacity_checkbox;
        private System.Windows.Forms.CheckBox color_checkbox;
        private System.Windows.Forms.CheckBox hello_world_checkbox;
        private System.Windows.Forms.Button super_mega_button;
    }
}
