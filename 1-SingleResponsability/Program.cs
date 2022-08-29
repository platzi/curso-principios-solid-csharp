using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");