
// Blink First Name

// Variables

int led1 = D7; 

void setup() {
    pinMode(led1, OUTPUT);
}

void loop() {

    //A
    digitalWrite(led1, HIGH);   // Code block for a dot
    delay(1000);
    digitalWrite(led1, LOW);

    delay(1000);

    digitalWrite(led1, HIGH);   //Code block for a dash
    delay(3000);
    digitalWrite(led1, LOW);

    delay(3000);

    //N
    digitalWrite(led1, HIGH);
    delay(3000);
    digitalWrite(led1, LOW);

    delay(1000);

    digitalWrite(led1, HIGH);
    delay(1000);
    digitalWrite(led1, LOW);

    delay(3000);

    //L
    digitalWrite(led1, HIGH);
    delay(1000);
    digitalWrite(led1, LOW);

    delay(1000);

    digitalWrite(led1, HIGH);
    delay(3000);
    digitalWrite(led1, LOW);

    delay(1000);

    digitalWrite(led1, HIGH);
    delay(1000);
    digitalWrite(led1, LOW);

    delay(1000);

    digitalWrite(led1, HIGH);
    delay(1000);
    digitalWrite(led1, LOW);

    delay(3000);

    //A
    digitalWrite(led1, HIGH);
    delay(1000);
    digitalWrite(led1, LOW);

    delay(1000);

    digitalWrite(led1, HIGH);
    delay(3000);
    digitalWrite(led1, LOW);

    delay(3000);

    //N
    digitalWrite(led1, HIGH);
    delay(3000);
    digitalWrite(led1, LOW);

    delay(1000);

    digitalWrite(led1, HIGH);
    delay(1000);
    digitalWrite(led1, LOW);

    delay(7000);
}