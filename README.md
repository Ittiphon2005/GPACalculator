
## รายละเอียดระบบ
ระบบนี้ช่วยให้นักศึกษาสามารถจองสนามบาสเกตบอลได้ผ่านแอปพลิเคชัน โดยมีการจัดการข้อมูลนักศึกษา สนาม และการจอง

## Class Diagram
```mermaid
classDiagram
    class Student {
        - string studentID
        - string name
        - string email
        + register()
        + bookCourt()
    }

    class Court {
        - string courtID
        - string location
        - bool isAvailable
        + checkAvailability()
        + reserveCourt()
    }

    class Booking {
        - string bookingID
        - Student student
        - Court court
        - DateTime bookingDate
        + confirmBooking()
        + cancelBooking()
    }

    class Admin {
        - string adminID
        - string username
        + manageCourts()
        + approveBooking()
    }

    Student --> Booking : makes
    Court --> Booking : is reserved in
    Admin --> Booking : manages
