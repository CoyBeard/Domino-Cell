#include <Servo.h>
#include <Stepper.h>

#include <AccelStepper.h>
#include <MultiStepper.h>

String lastInput = "null";

//Stepper Pins
const int step1 = 31;
const int dir1  = 32;
//const int enPin1 = 30;

const int step2 = 33;
const int dir2  = 34;
//const int enPin2 = 30;

const int step3 = 35;
const int dir3  = 36;
//const int enPin3 = 30;

const int step4 = 37;
const int dir4  = 38;

// Define some steppers and the pins the will use
AccelStepper Axis1(AccelStepper::DRIVER, step1, dir1); // Defaults to AccelStepper::FULL4WIRE (4 pins) on 2, 3, 4, 5

AccelStepper Axis2(AccelStepper::DRIVER, step2, dir2); // Defaults to AccelStepper::FULL4WIRE (4 pins) on 2, 3, 4, 5

AccelStepper Axis3(AccelStepper::DRIVER, step3, dir3); // Defaults to AccelStepper::FULL4WIRE (4 pins) on 2, 3, 4, 5

AccelStepper Axis4(AccelStepper::DRIVER, step4, dir4); // Defaults to AccelStepper::FULL4WIRE (4 pins) on 2, 3, 4, 5

void setup() {
  Serial.begin(9600);
  while (!Serial);

  pinMode(step1,OUTPUT);
  pinMode(dir1,OUTPUT);

  pinMode(step2,OUTPUT);
  pinMode(dir2,OUTPUT);

  pinMode(step3,OUTPUT);
  pinMode(dir3,OUTPUT);

  pinMode(step4,OUTPUT);
  pinMode(dir4,OUTPUT);

  digitalWrite(dir1,LOW);

  digitalWrite(dir2,LOW);

  digitalWrite(dir3,LOW);

  digitalWrite(dir4,LOW);

  Axis1.setMaxSpeed(100000000.0);
  Axis1.setAcceleration(10000.0);

  Axis2.setMaxSpeed(1000000000.0);
  Axis2.setAcceleration(100000.0);

  Axis3.setMaxSpeed(1000000000.0);
  Axis3.setAcceleration(10000.0);

  Axis4.setMaxSpeed(1000000000.0);
  Axis4.setAcceleration(10000.0);
}

void StepperMove (int Degrees, int Direction, int SSpeed, int stepPin, int dirPin) {
  //convert steps to degrees 
  Degrees = Degrees * (14000 / 711);
  
  //Sets Direction
  if (Direction == 0) {
    digitalWrite(dirPin,LOW);
  }else if (Direction == 1) {
    digitalWrite(dirPin,HIGH);
  }

  //Enables the motor to move in a particular direction
  //Makes 200 pulses for making one full cycle rotation
  
  for(int x = 0; x < Degrees; x++) {
    digitalWrite(stepPin,HIGH);

    delayMicroseconds(pow(1.06,((SSpeed * -1) + 139.5)));//800 home speed, 10 == 100%, 100 = 50%, 3000 = 1%

    digitalWrite(stepPin,LOW);

    delayMicroseconds(pow(1.06,((SSpeed * -1) + 139.5)));//1000
  }
}

void loop() {
  char input = Serial.read();
  if (input == '0') {
    lastInput = "ab";
  }
  if (input == '1') {
    lastInput = "aa";
    Axis1.move(100000000000000000000);
    Axis2.move(100000000000000000000);
    Axis3.move(100000000000000000000);
    Axis4.move(100000000000000000000);
  }

  if (lastInput == "aa") {
      Axis1.run();
      Axis2.run();
      Axis3.run();
      Axis4.run();
      if (Axis1.distanceToGo() == 0 || Axis2.distanceToGo() == 0 || Axis3.distanceToGo() == 0 || Axis4.distanceToGo() == 0) {
        Axis1.move(100000000000000000000);
        Axis2.move(100000000000000000000);
        Axis3.move(100000000000000000000);
        Axis4.move(100000000000000000000);
      }
  }
  if (lastInput == "ab") {
    Axis1.stop();
    Axis2.stop();
    Axis3.stop();
    Axis4.stop();
  }
}
