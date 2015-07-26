

const int pin6 = 6;
const int pin7 = 7;

const int ledPin =  13;  

void setup() {
  Serial.begin(57600);
  
  pinMode(ledPin, OUTPUT);
  
  pinMode(pin6, INPUT);
  pinMode(pin7, INPUT);
  
  digitalWrite(pin6, HIGH);
  digitalWrite(pin7, HIGH);
  
}

void loop() {
  if(digitalRead(pin6) == LOW) {
    Serial.write(6);
    Serial.flush();
    delay(20);  
  }
  
  if(digitalRead(pin7) == LOW) {
    Serial.write(7);
    Serial.flush();
    delay(20);  
  }
}



