
```mermaid
classDiagram
    class User {
        <<entity>>
        - string userID
        - string fullName
        - string emailAddress
        + signUp()
        + reserveCourt()
    }

    class Facility {
        <<entity>>
        - string facilityID
        - string location
        - bool available
        + checkFacilityStatus()
        + bookFacility()
    }

    class Reservation {
        <<control>>
        - string reservationID
        - User user
        - Facility facility
        - DateTime reservationTime
        + finalizeReservation()
        + cancelReservation()
    }

    class Administrator {
        <<boundary>>
        - string adminID
        - string username
        + overseeFacilities()
        + approveReservations()
    }

    User ..> Reservation : creates
    Facility --|> Reservation : is booked in
    Administrator o-- Reservation : oversees
