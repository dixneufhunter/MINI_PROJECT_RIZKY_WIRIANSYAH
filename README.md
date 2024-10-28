# Mini Project
Project ini adalah sebuah mini project yang berfungsi untuk mengelola data survey di wilayah Jakarta.

# Spesifikasi</BR>
Teknologi: ASP.NET MVC, .NET Core 5.0, IIS Server</BR>
Database: SQL Server 2019

## 1> REST API
![image](https://github.com/user-attachments/assets/07cf1958-1334-4cd7-8f8a-81ac3ca31a38)
--
   
## 2> Architecture Microservices
   ![image](https://github.com/user-attachments/assets/627baeb4-c405-4852-9c6f-f83093b3ec17)
--

## 3> Relational Database
![image](https://github.com/user-attachments/assets/ffeda29d-37c2-4f89-bf0c-f2d30b435922)

--

## 4> Transactional Function (CRUD)
a. Page Index
![image](https://github.com/user-attachments/assets/0afcbcc1-513f-4c0e-97ff-0d47544d4ae2)
b. Page Create
![image](https://github.com/user-attachments/assets/4d8e0163-9f51-43f5-ae12-3af94b376876)
c. Page Edit
![image](https://github.com/user-attachments/assets/d3394371-0ad0-4c67-8a26-1d8d9d8e89fe)
d. Page Details
![image](https://github.com/user-attachments/assets/09923ae0-6e70-4787-bf9d-37135340ee2f)
--


## Examples

**Input:**
```yaml
basePath: /api/
paths:
  /Survey/GetSurveys:
    get: {}
  /Survey/CreateSurvey
    post: {}
  /Survey/EditSurveyData/{id}
    put: {}
  /Survey/DeleteSurvey/{id}
    delete: {}
```

**Output:**

```
GET /api/Survey/GetSurveys
POST /api/Survey/CreateSurvey
PUT /api/Survey/EditSurveyData/{id}
```

---

   




