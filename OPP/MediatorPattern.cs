using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public interface Mediator
    {
        void Notify(object sender, string type, string message);
    }

    public class Student
    {
        public string name;
        public Mediator mediator;

        public Student(string name, Mediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }
    }

    public class Teacher
    {
        public string name;
        public Mediator mediator;

        public Teacher(string name, Mediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }
    }

    public class Administration
    {
        public string name;
        public Mediator mediator;

        public Administration(string name, Mediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }
    }

    public class KTUMediator : Mediator
    {
        public List<Administration> admins = new();
        public List<Teacher> teachers = new();
        public List<Student> students = new();

        public KTUMediator()
        {

        }
        public void Notify(object sender, string type, string message)
        {
            if (sender.GetType() == typeof(Teacher))
                ReactOnTeacherMsg(type, message);
            if (sender.GetType() == typeof(Student))
                ReactOnStudentMsg(type, message);
            if (sender.GetType() == typeof(Administration))
                ReactOnAdminMsg(type, message);
        }

        public void setAdmins(List<Administration> admins) { this.admins = admins; }
        public void setTeachers(List<Teacher> teachers) { this.teachers = teachers; }
        public void setStudent(List<Student> students) { this.students = students; }

        private void ReactOnStudentMsg(string type, string message)
        {
            var teacher = teachers.Where(teacher => type == teacher.name).Single();

            Console.WriteLine($"{teacher.name} received message: {message}");
        }

        private void ReactOnAdminMsg(string type, string message)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.name} received message: {message}");
            }
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"{teacher.name} received message: {message}");
            }
        }

        private void ReactOnTeacherMsg(string type, string message)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.name} received message: {message}");
            }
        }
    }
}
