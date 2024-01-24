using binding.Models;

namespace binding
{
    public partial class MainPage : ContentPage
    {
   public Student student { get; set; }

        public MainPage()
        {
            InitializeComponent();
            student = new Student() { Name = "Shahar", Age = 16 };
            this.BindingContext = student;
        }
        private void ChangeName(object sender, EventArgs e)
        {
            student.Name = "נועה";
        }
     
    }
}