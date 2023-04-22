Main();
static void Main() {
    Console.WriteLine("Hello World");
    
    string[,]str=MakeMatrix();
    int[]arr=CorrectAnswer();
    Ask(str,arr);
  }
  
  
  static string[,]MakeMatrix()
  {
      string[,]arr=new string[4,5];
      arr[0,0]="Question 1";
      arr[0,1]="Ansver 1 1";
      arr[0,2]="Ansver 1 2";
      arr[0,3]="Ansver 1 3";
      arr[0,4]="Ansver 1 4";
      
      arr[1,0]="Question 2";
      arr[1,1]="Ansver 2 1";
      arr[1,2]="Ansver 2 2";
      arr[1,3]="Ansver 2 3";
      arr[1,4]="Ansver 2 4";
      
      arr[2,0]="Question 3";
      arr[2,1]="Ansver 3 1";
      arr[2,2]="Ansver 3 2";
      arr[2,3]="Ansver 3 3";
      arr[2,4]="Ansver 3 4";
      
      arr[3,0]="Question 4";
      arr[3,1]="Ansver 4 1";
      arr[3,2]="Ansver 4 2";
      arr[3,3]="Ansver 4 3";
      arr[3,4]="Ansver 4 4";
      
      return arr;
  }
  
  static int[]CorrectAnswer()
  {
      int[]arr=new int [4];
      arr[0]=3;
      arr[1]=3;
      arr[2]=2;
      arr[3]=1;
      return arr;
  }
  
  static void Ask(string[,]arr,int[]arr1)
  {
      for(int i=0;i<arr.GetLength(0);i++)
      {
          for(int j=0;j<arr.GetLength(1);j++)
          {
              Console.WriteLine(arr[i,j]);
                  
          }
          Console.WriteLine("Make your choise");
          int num=int.Parse(Console.ReadLine());
          if(num==arr1[i])
          {
              Console.WriteLine("Correct");
          }
          else
          {
              Console.WriteLine("Uncorrect");
          }
      }
  }