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


