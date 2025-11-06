using ConsoleApp1;


//bool isTrue = true;
//char character = 'A';
//char[] chars = {'i', 's', 'T', 'r', 'u', 'e'};
//string str = new string(chars); // 형변환 ( 문자 배열 -> 문자열 )

//Console.WriteLine(str + " : " + isTrue);

//Console.ReadKey();


// 상수, enum 선언

//const int SUNDAY = 0;
//const int MONDAY = 1;
//const int TUESDAY = 2;
//const int WEDNESDAY = 3;
//const int THURSDAY = 4;
//const int FRIDAY = 5;
//const int SATURDAY = 6;

//SUNDAY = 2; // 오류 발생: 상수는 값을 변경할 수 없습니다.

//class Program
//{
//    static void Main(string[] args)
//    {
//        Days days = Days.Sunday;

//        //if(days == Days.Sunday)
//        //{
//        //    Console.WriteLine("오늘은 일요일입니다.");
//        //}
//        //if (days == Days.Monday)
//        //{
//        //    Console.WriteLine("오늘은 월요일입니다.");
//        //} 

//        // 위와 같이 변화되는 문자열이나 숫자 대신 enum을 사용하면 가독성이 좋아짐

//        Console.WriteLine(days);
//        Console.ReadKey();
//    }
//}


//enum Days // 가독성 up 열거형 선언
//{
//    Sunday,     // 0
//    Monday,     // 1
//    Tuesday,    // 2
//    Wednesday,  // 3
//    Thursday,   // 4
//    Friday,     // 5
//    Saturday    // 6
//};


// 명시적 선언 (Explicit Declaration)
//int number;  // 선언을 할 때 자료형을 명시적으로 지정
//string test = "Hello";
//double d = 3.14;
//Dictionary<string, List<Tuple<int, string>>> complexDict = new Dictionary<string, List<Tuple<int, string>>>();

//// 암시적 선언 (Implicit Declaration)
//var number2 = 10; // 선언을 할 때 자료형을 명시하지 않지만 값을 반드시 초기화 해줘야 함
//var test2 = "World";
//var d2 = 3.14;
//var complexDict2 = new Dictionary<string, List<Tuple<int, string>>>();

//Console.ReadKey();

// 비트 연산자

//int a = 192; // 11000000
//int b = 168; // 10101000
//// 비트 연산자 예제    
////           And 10000000 = 128
////           Or  11101000 = 232
////           Xor 01101000 = 104

//Console.WriteLine("a & b = " + (a & b));   // 비트 AND
//Console.WriteLine("a | b = " + (a | b));   // 비트 OR
//Console.WriteLine("a ^ b = " + (a ^ b));   // 비트 XOR

//// a = 00000000 00000000 00000000 11000000
//// ~a = 11111111 11111111 11111111 00111111 1의 보수

//// 1의 보수, 2의 보수
//// 11111111 11111111 11111111 00111111
//// 1의 보수
//// 00000000 00000000 00000000 11000000
//// 2의 보수
//// 00000000 00000000 00000000 11000001 = -63

//// ~a = -193
//Console.WriteLine("~a = " + (~a));         // 비트 NOT

//// a = 00000000 00000000 00000000 11000000

//Console.WriteLine("a << 2 = " + (a << 2));
//// a << 2 = 00000000 00000000 00000011 00000000 = 768 비트 왼쪽 시프트

//Console.WriteLine("a << 2 = " + (a >> 2));
//// a >> 2 = 00000000 00000000 00000000 00110000 = 48 비트 오른쪽 시프트
//Console.ReadKey();

//byte b = 5;

//// b = 0000 0101

//Console.WriteLine($"~b = {~b}");
//// ~b = 1111 1010 = -6
//Console.ReadKey();


// Null 병합 연산자

//Nullable<int> a = null;
//int? a = null;  // 위의 선언과 동일
//// 즉 선언할 때 Type 뒤에 ?를 붙이면 Nullable<T> 타입으로 선언됨

//// Nullable 체크 해보기
//Console.WriteLine($"a.HasValue = {a.HasValue}"); // false

//int b = a ?? 10; // a가 null이면 10을 대입

//int? b2 = 5;

//a ??= b2; // a가 null이면 b2의 값을 대입

//Console.ReadKey();


// 디버깅 단축키
// 디버깅 시작 단축키 F5
// 중단점 단축키 F9
// 한 단계씩 실행 단축키 F10
// 함수 안으로 들어가기 단축키 F11
// 함수 밖으로 나오기 Shift + F11
// 디버깅 다시 시작 Ctrl + Shift + F5



// 전반적인 if 삼항 등 JAVA와 비슷한거같음


// input 

//Console.Write("숫자 입력 : ");
//string? input = Console.ReadLine();

//int num = int.Parse(input ?? "0"); // null 병합 연산자 사용

//Console.WriteLine("입력한 숫자 : " + input);
//if (num == 0)
//{
//    Console.WriteLine("0입니다.");
//}
//else if(num % 2 != 0)
//{
//    Console.WriteLine("입력한 숫자는 홀수입니다.");
//}
//else if (num % 2 == 0)
//{
//    Console.WriteLine("입력한 숫자는 짝수입니다.");
//}

//Console.ReadKey();

// switch case

// JAVA 와 동일

//string grade = "A";
//string grade2 = "D";

//switch (grade)
//{
//    case "A":
//        Console.WriteLine("우수 회원입니다.");
//        break;
//    case "B":
//        Console.WriteLine("일반 회원입니다.");
//        break;
//    case "C":
//        Console.WriteLine("준회원입니다.");
//        break;
//    case string g when (g == "D" || g == "F"): // 비교 연산자 사용 가능
//        Console.WriteLine("탈퇴 회원입니다.");
//        break;
//    default:
//        Console.WriteLine("손님입니다.");
//        break;
//}

//string message = grade2 switch
//{
//    "A" => "우수 회원입니다.",
//    "B" => "일반 회원입니다.",
//    "C" => "준회원입니다.",
//    "D" or "F" => "탈퇴 회원입니다.", // or 연산자 사용 가능
//    _ => "손님입니다."
//}; // switch 표현식

//Console.WriteLine(message);
//Console.ReadKey();


// 배열
// 이것도 뭐 비슷할거같음

//int[] numbers = new int[5]; // 길이가 5인 정수형 배열 선언
//string[] fruits = new string[5]; // 길이가 5인 문자열형 배열 선언

//// numbers = [0, 0, 0, 0, 0]
//// fruits = [null, null, null, null, null]

//numbers = new int[] {10, 20, 30, 40, 50 }; // 배열 초기화
//fruits = ["사과", "바나나", "레몬", "포도"]; // 배열 초기화 C# 9.0

//// 요소 접근
//numbers[0] = 100; // 첫 번째 요소에 값 할당
//Console.WriteLine("첫 번째 숫자: " + numbers[0]);
//Console.WriteLine("두 번째 과일: " + fruits[1]);

//// C# 8.0 ^ 연산자
//fruits[fruits.Length - 1] = "오렌지"; // 마지막 요소에 값 할당
//Console.WriteLine("마지막 과일 : " + fruits[^1]);
//Console.WriteLine("뒤에서 두번째 과일 : " + fruits[^2]); // 끝에서 두 번째 요소 접근)

//Console.ReadKey();

// 반복문

// 전반적인 반복문은 JAVA와 비슷하나 다른게 있음

//int[] numbers = { 10, 20, 30, 40, 50 };

//for(int i = 0; i < numbers.Length; i++) // Length 속성 (JAVA의 length() 메서드와 비슷)
//{
//    Console.WriteLine("numbers[" + i + "] = " + numbers[i]);
//}

//foreach(int num in numbers)
//{
//    Console.WriteLine("num : " + num);
//}

// 다차원 배열

//int[,] matrix = new int[2, 3]; // 2행 3열 배열

//int[,] matrix2 = { 
//    { 1, 2, 3 }, 
//    { 4, 5, 6 }
//}; // 배열 초기화 

//Console.WriteLine(matrix2[1, 1]);

//Console.WriteLine(matrix2.GetLength(0));
//Console.WriteLine(matrix2.GetLength(1));

//for(int i = 0; i < matrix2.GetLength(0); i ++)
//{
//    for(int j = 0; j < matrix2.GetLength(1); j++)
//    {
//        Console.Write(matrix2[i, j] + " ");
//    }
//    Console.WriteLine();
//}

// 가변 배열 선언(각 배열의 크기가 다를 수 있음)
//int[][] jaggedArray = new int[3][];

//// 각 행에 다른 크기의 배열을 할당
//jaggedArray[0] = new int[] { 1, 2 };
//jaggedArray[1] = new int[] { 3, 4, 5 };
//jaggedArray[2] = new int[] { 6, 7, 8, 9 };

//int[][] jaggedArray2 =
//{
//    [1, 2],
//    [3, 4, 5],
//    [6, 7, 8, 9]
//};

////Console.WriteLine(jaggedArray[2][3]); // 9


//foreach (int[]array in jaggedArray2)
//{
//    foreach(int item in array)
//    {
//        Console.Write(item + " ");
//    }
//    Console.WriteLine();
//}


//int[] numbers = { 5, 3, 4, 7, 8, 1, 2, 6 };
//Array.Sort(numbers); // 배열 정렬
//Array.Reverse(numbers); // 배열 역순 정렬

//Console.WriteLine("정렬된 배열");

//foreach(int num in numbers)
//{
//    Console.Write(num + " ");
//}

//int[] numbers = { 1, 2, 3, 4, 5 };
//int index = Array.IndexOf(numbers, 1);  // indexOf : 1의 위치를 numbers 배열에서 찾음
// index 크기를 벗어나면 -1 반환
//Console.Write(index);

//int[] numbers = { 1, 2, 3 };
//Array.Resize(ref numbers, 5); // 배열 크기 변경 (참조로 전달 즉, 원본의 변경을 야기함)
//Console.WriteLine(numbers.Length); // 5
//Console.WriteLine("************");
//foreach (int num in numbers)
//{
//    Console.Write(num + " ");
//}
//Console.ReadKey();


//string text = "Hello, World!";
//Console.WriteLine(text.Contains("World")); // 뭔가 이거 DB에서 많이 쓰일지도 포함여부 확인하는걸로
//Console.WriteLine(text.Equals("hello  world!")); // 대소문자 구분해서 비교
//Console.WriteLine(text.Equals("hello  world!",StringComparison.InvariantCultureIgnoreCase)); // 대소문자 구분해서 비교
//Console.WriteLine(text.ToUpper()); 
//Console.WriteLine(text.ToLower()); 


//using ConsoleApp1;
//using System.ComponentModel.DataAnnotations;

//Car car = new Car();

//Console.WriteLine("자동차 브랜드: " + car.brand);
//Console.WriteLine("자동차 모델: " + car.model);
//Console.WriteLine("자동차 색상: " + car.color);

//car.showInfo();
//Console.WriteLine("*************");
//Console.WriteLine(car.GetBrand());
//Console.WriteLine(car.GetModel());
//Console.WriteLine(car.GetColor());
//Console.WriteLine("*************");
//car.showInfo(false, true, false); 
//Console.WriteLine("*************");
//car.showInfo("color", "brand");


// ref, out 키워드

//void TestRef(ref int x)
//{
//    x = x + 10;
//}
//void TestOut(out int y)
//{
//    y = 20;
//}
//int a = 5;
//TestRef(ref a); // a의 값이 변경됨
//Console.WriteLine("ref 사용 후 a의 값: " + a); // 15
//int b;
//TestOut(out b); // b의 값이 할당됨
//Console.WriteLine("out 사용 후 b의 값: " + b); // 20

// ref와 out의 차이점
// ref는 메서드 호출 전에 반드시 초기화가 되어 있어야 하지만 out은 초기화되지 않아도 됨

//string txt = "1";

//bool success = int.TryParse(txt, out int result); // 변환에 성공하면 true, 실패하면 false 반환 
//if (success)
//{
//    Console.WriteLine("변환 성공: " + result);
//}
//else
//{
//    Console.WriteLine("변환 실패");
//}

//using ConsoleApp1;

//Person ps1 = new Person();
//ps1.Name = "홍길동";

//// getter, setter 가 자동으로 생성되어서 아래처럼 사용 가능
//Console.WriteLine(ps1.Name);





//using ConsoleApp1;

//Person person = new Person();

//person.Name = "홍길동"; 
//Console.WriteLine(person.GetName());


//void Test()
//{
//    for (int i = 0; i < 1000000; i++)
//    {
//        new myClass(i);
//    }
//}

//Test();

//Animal dog = new Dog();

//dog.Eat();


//IAnimal dog2 = new Dog2();  
//IAnimal bird = new Bird();
//IFlyable bird2 = new Bird();

//dog2.MakeSound();  
//bird.MakeSound();
//bird2.Fly();

// 암시적 변환, 명시적 변환

//int intNum = 100;
//double doubleNum = intNum; // 암시적 변환
//Console.WriteLine($"int : {intNum}, double : {doubleNum}");

//double anotherDouble = 9.78;
//int anotherInt = (int)anotherDouble; // 명시적 변환
//Console.WriteLine($"double : {anotherDouble}, int : {anotherInt}");

//// 암시적 변환 : 작은 범위의 자료형에서 큰 범위의 자료형으로 변환될 때 자동으로 수행
//// 명시적 변환 : 큰 범위의 자료형에서 작은 범위의 자료형으로 변환될 때 개발자가 직접 형변환을 지정해야 함


// object 타입

//object stringObject = "C# Programming"; 
//object intObject = 42;
//object doubleObject = 3.14; 
//object doubleObject2 = 9.78;
//object boolObject = true;
//object classObject = new Person("홍길동");

// as 연산자

//object obj = "Hello, World!";
//string? str = obj as string;

//if (str != null)
//{
//    Console.WriteLine("문자열 길이: " + str.Length);
//}
//else
//{
//    Console.WriteLine("obj는 문자열이 아닙니다.");
//}


// Convert 클래스
//string strNumber = "789";
//int cvt = Convert.ToInt32(strNumber); // 32 비트의 정수 즉 int형으로 변환
//Console.WriteLine($"변환된 정수: {cvt}");


// 구조체
// 특징     구조체(sturct)        클래스(class)
// 타입    값 형식               참조 형식
// 메모리  스택에 할당           힙에 할당
// 상속    불가능                가능
// 용도    간단한 데이터 그룹화   복잡한 데이터 및 동작 포함

//Point point = new Point {  X = 10, Y = 20 };

//void ChangePoint(Point p)
//{
//    p.X = 30;
//    p.Y = 40;
//}

//ChangePoint(point);

//Console.WriteLine(point);
//Console.ReadKey();
//struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public override string? ToString()
//    {
//        return $"X : {X}, Y: {Y}";
//    }
//}


// 제네릭

// 클래스, 메서드, 인터페이스 등을 정의할 때 자료형을 일반화하여 다양한 자료형에 대해 재사용할 수 있도록 하는 기능
// 데이터 타입을 일반화하여 재사용성을 높이고 타입 안정성을 제공하는 기능

//string a = "bbbbbb";
//string b = "aaaaaa";

//void Swap<T>(ref T a , ref T b)
//{
//    T temp = a;
//    a = b;
//    b = temp;
//}

//Swap(ref a, ref b);
//Console.WriteLine($"a : {a}, b : {b}");


// 제네릭 제약 조건


T CreateInstance<T>() 
    where T : Animal, new()// struct, new()  // T는 값 형식이어야 하고 매개변수가 없는 생성자가 있어야 함

{
    T instance = new T();
    instance.MakeSound();
    return instance;
}

var animal = CreateInstance<Dog>();
Console.WriteLine(animal);
Console.ReadKey();


abstract class Animal
{
    abstract public string Name { get; }
    abstract public void MakeSound();
    public override string ToString()
    {
        return $"제 이름은 {Name}입니다.";
    }
}
class Dog : Animal
{
    public override string Name => "멍멍이";

    public override void MakeSound()
    {
        Console.WriteLine("멍멍!");
    }
}
class Cat : Animal
{
    public override string Name => "야옹이";

    public override void MakeSound()
    {
        Console.WriteLine("야옹!");
    }
}