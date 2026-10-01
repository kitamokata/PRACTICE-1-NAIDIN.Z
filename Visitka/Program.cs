const string FullName = "Найдин Захар Сергеевич";
string NameGroup = "ИСП-254";
int course = 2;
string spec = "09.02.07";
// оценки за 3 работы нужны для расчета средней оценки
int firstGrade = 4;
int secondGrade = 5;
int threeGrade = 4;
bool scholarship = false;
const double scholarshipGrade = 4.2;
double averageGrade = (firstGrade + secondGrade + threeGrade) / 3.0;
int allWeek = 16;
int pastWeek = 2;

//Использовал if, вы говорили на лекции
if (averageGrade >= scholarshipGrade)
{
    scholarship = true;
}

Console.WriteLine("=======ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА=======");
Console.WriteLine($"ФИО: {FullName}");
Console.WriteLine($"Группа: {NameGroup}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Специальность: {spec}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {(int)(averageGrade * 100) / 100.0}"); // умножаем на 100, int убирает дробную часть, и делим на 100, получаем два знака после запятой
Console.WriteLine($"Стипендия положена (>= {scholarshipGrade}): {scholarship}");
Console.WriteLine();
Console.WriteLine($"Учебных недель осталось в семестре: {allWeek - pastWeek}");
Console.WriteLine("========================================");
