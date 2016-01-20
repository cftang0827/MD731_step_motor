int d_1_Clockwise = 3; //後
int d_1_counterClockwise = 5; //前
int d_2_Clockwise = 6; // 左
int d_2_counterClockwise = 9; //右
int d_3_Clockwise = 10; //往上走
int d_3_counterClockwise = 11; //往下走

void setup() {
  // put your setup code here, to run once:
  pinMode(d_1_Clockwise,OUTPUT);
  pinMode(d_2_Clockwise,OUTPUT);
  pinMode(d_3_Clockwise,OUTPUT);
  pinMode(d_1_counterClockwise,OUTPUT);
  pinMode(d_2_counterClockwise,OUTPUT);
  pinMode(d_3_counterClockwise,OUTPUT);
  Serial.begin(9600);
  
}

void loop() {
  
  // put your main code here, to run repeatedly:
  char input = Serial.read(); // Get from serial port
  int delayNum1 = 300; 
  switch(input)
  {
    case '1':
      push(d_1_Clockwise,delayNum1);
      break;
    case '2':
      push(d_1_counterClockwise,delayNum1);
      break;
    case '3':
      push(d_2_Clockwise,delayNum1);
      break;
    case '4':
      push(d_2_counterClockwise,delayNum1);
      break;
    case '5':
      push(d_3_Clockwise,delayNum1);
      break;
    case '6':
      push(d_3_counterClockwise,delayNum1);
      break;  
  }                            
}     

void push(int pin,int delayNum)
{
  Serial.println("OK");
  analogWrite(pin,160);
  delay(delayNum);
  analogWrite(pin,0);
}


