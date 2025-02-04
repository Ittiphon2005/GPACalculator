## รายละเอียดระบบ
ระบบนี้ช่วยให้นักศึกษาสามารถจองสนามบาสเกตบอลได้ผ่านแอปพลิเคชัน โดยมีการจัดการข้อมูลนักศึกษา สนาม และการจอง

## Class Diagram
```mermaid
classDiagram
    class Student {
        <<entity>>
        - string studentID
        - string name
        - string email
        + register()
        + bookCourt()
    }

    class Court {
        <<entity>>
        - string courtID
        - string location
        - bool isAvailable
        + checkAvailability()
        + reserveCourt()
    }

    class Booking {
        <<control>>
        - string bookingID
        - Student student
        - Court court
        - DateTime bookingDate
        + confirmBooking()
        + cancelBooking()
    }

    class Admin {
        <<boundary>>
        - string adminID
        - string username
        + manageCourts()
        + approveBooking()
    }

    Student ..> Booking : creates
    Court --|> Booking : is reserved in
    Admin o-- Booking : oversees
