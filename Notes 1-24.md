# January 24, 2023

Rewriting the knowledge probe problem from `procedural` style to `object-oriented`

## Procedural
```cpp
// procedural.cc
#include <iostream>

int calculateWage(int baseSalary, int hourlyRate, int extraHours) {
  return baseSalary + hourlyRate * extraHours;
}

int main(void) {
   int baseSalary = 50'000;
   int hourlyRate = 20;
   int extraHours = 10;
   std::cout << calculateWage(baseSalary, hourlyRate, extraHours) << std::endl;
}
```

## Object-Oriented
main.cc
```cpp
#include <iostream>
#include "Employee.h"

int main(void) {
    Employee employee1(50'000, 20);
    std::cout << employee1.calculateWage(10) << std::endl;
}
```

Employee.h
```cpp
#pragma once
class Employee {
private:
    int baseSalary;
    int hourlyRate;
public:
    Employee() = default;
    Employee(int, int);
    void setBaseSalary(int);
    void setHourlyRate(int);
};
```

Employee.cc
```cpp
#include "Employee.h"
#include <stdexcept>

Employee::Employee(int baseSalary, int hourlyRate) {
    setBaseSalary(baseSalary);
    setHourlyRate(hourlyRate);
}

void Employee::setBaseSalary(int baseSalary) {
    if (baseSalary <= 0) {
        throw std::invalid_argument("baseSalary must be greater than 0");
    }
    this->baseSalary = baseSalary;
}

void Employee::setHourlyRate(int hourlyRate) {
    if (hourlyRate <= 0) {
        throw std::invalid_argument("hourlyRate must be greater than 0");
    }
    this->hourlyRate = hourlyRate;
}
```
