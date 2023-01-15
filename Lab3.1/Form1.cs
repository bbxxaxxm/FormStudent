namespace Lab3._1
{
    public partial class Form1 : Form
    {
        List<string> players = new List<string>();
        List<double> grades = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                _name = textBox1.Text,
                _id = textBox2.Text,
                _year = int.Parse(textBox3.Text),
                _tall = double.Parse(textBox4.Text),
                _grade = double.Parse(textBox5.Text),
                _major = textBox6.Text
            };
            //เพิ่มนักเรียนเข้าไปเก็บในListที่มีชื่อว่าplayers
            players.Add(student._name);
            //เพิ่มคะแนนของนักเรียนเข้าไปเก็บในListที่มีชื่อว่าgrades
            grades.Add(student._grade);

            //เรียงข้อมูลทีอยู่ในListที่มีชื่อว่าgradesใหม่
            grades.Sort();

            //นำข้อมูลส่วนหัวของList gradesมาแสดง
            //เข้าถึงTextboxที่มีชื่อว่า TopGrade ก่อน
            TopGrade.Text = "คะแนนสูงสุดคือ " + grades.Last().ToString();

            //นำข้อมูลส่วนท้ายของList gradesมาแสดง
            MinGrade.Text = "คะแนนต่ำสุดคือ " + grades.First().ToString();

            //แสดงจำนวนนักเรียนทั้งหมด โดยเราจะใช้Listที่มีชื่อว่า players และใช้คำสั่ง .Count
            //อย่างแรกเข้าถึงTextbox ที่มีชื่อว่า AllStudentsก่อน
            AllStudents.Text = "นักเรียนทั้งหมดมี " + players.Count.ToString() + " คน";

            //จากนั้นเราก็ทำการเพิ่มนักเรียนเข้าในData grid
            table.Rows.Add(
                student._name,
                student._id,
                student._year,
                student._tall,
                student._grade,
                student._major
                );
        }



        private void Clear_Click_1(object sender, EventArgs e)
        {
            //เคลียข้อมูลในtable
            table.Rows.Clear();

            //ใส่ข้อความให้Textbox TopGrade, MinGrade, AllStudents ให้เป็นข้อความว่า 0 คน 0 เกรด
            TopGrade.Text = "คะแนนสูงสุดคือ 0";
            MinGrade.Text = "คะแนนต่ำสุดคือ 0";
            AllStudents.Text = "นักเรียนทั้งหมดมี 0 คน";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //เมื่อฟอรืมทำการโหลดขึ้นมาก็ให้ตั้งข้อความในสรุปยอด เป็น0เหมือนกัน
            //เพราะถ้าเราไม่ตั้งเวลาเปิดขึ้นมามันจะไม่ขึ้นอะไร
            TopGrade.Text = "คะแนนสูงสุดคือ 0";
            MinGrade.Text = "คะแนนต่ำสุดคือ 0";
            AllStudents.Text = "นักเรียนทั้งหมดมี 0 คน";
        }
    }
}