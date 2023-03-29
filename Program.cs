class Program {
    static int Max1(int x, int y, int z) {
        if(y > z) {
            return y;
        }
        return z;
    }
   static void Main(string[] args) {
    Console.Write("input N: ");
    int N = int.Parse(Console.ReadLine());
     if(N > 1 && N < 10000){
        Console.Write("input K: ");
        int K = int.Parse(Console.ReadLine());
        if(K > 1 && K < 1000) {
            Console.Write("input Score: ");
            int Score = int.Parse(Console.ReadLine());
            
            
        }
    }
   }
}
