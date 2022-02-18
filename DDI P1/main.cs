using System;
class HelloWorld {
  static void Main() {
        int[] input = new int[5] {8,1,2,2,3};
        int[] outList = new int [input.Length];
        
        printArray(input);
        minorInArray(input,outList);
        Console.WriteLine("----");
        printArray(outList);
  }
  
  static void printArray(int[] List){
        int i;

        for(i = 0; i< List.Length; i++)
            Console.Write(List[i] + "\n");
  }
  
  static void minorInArray(int [] List, int[] outList){
      int i, j, acum;

      for(i = 0; i < List.Length; i++){
            acum = 0;
            for(j = 0; j < List.Length; j++){
                    if(List[j] < List[i])
                        acum++;
            }
            outList[i] = acum;
      }
  }
}
