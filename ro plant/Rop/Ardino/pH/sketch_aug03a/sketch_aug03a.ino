//Function: The PH sensor output voltage value, 
//          convert into PH and then display in the serial monitor.
#define Vref 4.95
void setup()
{ 
  Serial.begin(9600);
}
void loop()
{
  int sensorValue;
  int m;
  long sensorSum;
  for(m=0;m<50;m++)
  {
    sensorValue=analogRead(A1);//Connect the PH Sensor to A0 port
    sensorSum += sensorValue;
  }
   sensorValue =   sensorSum/50;
 Serial.print(" the PH value is"); 
 Serial.println(7-1000*(sensorValue-372)*Vref/59.16/1023);
 delay(2000);
}
