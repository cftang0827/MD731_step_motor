int analogPin = 9;
int ditalPin = 12;
void setup() {
  // put your setup code here, to run once:
  pinMode(analogPin,OUTPUT);
  Serial.begin(9600);
  pinMode(ditalPin,OUTPUT);
}



void loop() {
  
  // put your main code here, to run repeatedly:
  while(Serial.read() == 'a')
  {
    Serial.println("OK");
    digitalWrite(ditalPin,HIGH);
    delay(500);
    digitalWrite(ditalPin,LOW);
    
    
//    analogWrite(analogPin, 150);
//    delay(120);
//    analogWrite(analogPin, 0);
  }

}
