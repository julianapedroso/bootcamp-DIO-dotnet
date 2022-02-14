using System;

namespace Student_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            int studentIndex = 0;
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do(a) estudante:");
                        Student student = new Student();
                        student.Name = Console.ReadLine();

                        Console
                            .WriteLine("Agora, informe a nota do(a) estudante:");

                        // Tentativa de conversão para decimal
                        if (
                            decimal
                                .TryParse(Console.ReadLine(), out decimal grade)
                        )
                        {
                            student.Grade = grade;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota precisa ser decimal");
                        }

                        students[studentIndex] = student;
                        studentIndex++;

                        break;
                    case "2":
                        foreach (var s in students)
                        {   
                            if(!string.IsNullOrEmpty(s.Name))
                            {
                                Console.WriteLine($"Estudante: {s.Name} | Nota: {s.Grade}");
                            }
                        }
                        break;
                    case "3":
                    decimal totalGrade = 0;
                    int studentNumber = 0;

                    for (int i = 0; i < students.Length; i++)
                    {
                        if(!string.IsNullOrEmpty(students[i].Name))
                        {
                            totalGrade = totalGrade + students[i].Grade;
                            studentNumber++;
                        }
                    }

                        decimal generalAverage = totalGrade / studentNumber;
                        ConceptEnum generalConcept;

                        if(generalAverage < 2 )
                        {
                            generalConcept = ConceptEnum.E;
                        } else if (generalAverage < 4)
                        {
                            generalConcept = ConceptEnum.D;
                        } else if (generalAverage < 6)
                        {
                            generalConcept = ConceptEnum.C;
                        } else if (generalAverage < 8)
                        {
                            generalConcept = ConceptEnum.B;
                        } else 
                        {
                            generalConcept = ConceptEnum.A;
                        }

                        Console.WriteLine($"Média Geral: {generalAverage} | Conceito: {generalConcept}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = GetUserOption();
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine();
            return userOption;
        }
    }
}
