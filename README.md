## รายละเอียดระบบ
ระบบนี้ประกอบด้วย 4 คลาสหลัก ได้แก่ **Student**, **Court**, **Booking**, และ **Admin** ซึ่งทำหน้าที่ต่าง ๆ ในการจัดการข้อมูลและกระบวนการจองสนามบาสเกตบอล

### 1. **Student Class**:
- **Attributes**:
  - `studentID`: รหัสประจำตัวนักศึกษา
  - `name`: ชื่อของนักศึกษา
  - `email`: อีเมลของนักศึกษา
- **Methods**:
  - `register()`: ฟังก์ชันสำหรับการสมัครสมาชิกของนักศึกษา
  - `bookCourt()`: ฟังก์ชันสำหรับการจองสนาม

### 2. **Court Class**:
- **Attributes**:
  - `courtID`: รหัสประจำสนาม
  - `location`: ตำแหน่งที่ตั้งของสนาม
  - `isAvailable`: สถานะการว่างของสนาม
- **Methods**:
  - `checkAvailability()`: ฟังก์ชันตรวจสอบสถานะความว่างของสนาม
  - `reserveCourt()`: ฟังก์ชันสำหรับการจองสนาม

### 3. **Booking Class**:
- **Attributes**:
  - `bookingID`: รหัสการจอง
  - `student`: อ้างอิงถึง **Student** ที่ทำการจอง
  - `court`: อ้างอิงถึง **Court** ที่ถูกจอง
  - `bookingDate`: วันที่และเวลาของการจอง
- **Methods**:
  - `confirmBooking()`: ฟังก์ชันสำหรับยืนยันการจอง
  - `cancelBooking()`: ฟังก์ชันสำหรับยกเลิกการจอง

### 4. **Admin Class**:
- **Attributes**:
  - `adminID`: รหัสผู้ดูแลระบบ
  - `username`: ชื่อผู้ใช้ของผู้ดูแล
- **Methods**:
  - `manageCourts()`: ฟังก์ชันสำหรับการจัดการสนาม
  - `approveBooking()`: ฟังก์ชันสำหรับการอนุมัติการจอง

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
