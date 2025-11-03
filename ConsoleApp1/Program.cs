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

int[] numbers = { 1, 2, 3 };
Array.Resize(ref numbers, 5); // 배열 크기 변경 (참조로 전달 즉, 원본의 변경을 야기함)
Console.WriteLine(numbers.Length); // 5
Console.WriteLine("************");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}
Console.ReadKey();