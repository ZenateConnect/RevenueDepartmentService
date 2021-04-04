# RESTful API กรมสรรพากร / The Revenue Department Service

ระบบจัดการ Service ของกรมสรรพากร โดยใช้ RESTful API ในการเชื่อมต่อกับ SOAP Web Service และแปลงข้อมูลให้อยู่ในรูปแบบของ JSON และใช้ Swagger
Code ทั้งหมดนี้เป็นเพียง Code ตั้งต้น เพื่อนำไปต่อยอดต่อไป

Document ของกรมสรรพากร: <a href='http://www.rd.go.th/publish/42545.0.html' target='_blank'>http://www.rd.go.th/publish/42545.0.html</a>
API นี้จะประกอบไปด้วย Service ดังนี้ (รายละเอียดสามารถดูได้ตามลิงค์ที่แนบไว้)

1. Common Service: <a href='http://www.rd.go.th/publish/42539.0.html' target='_blank'>คลิกเพื่อดู Document</a>
2. TIN Service: <a href='http://www.rd.go.th/publish/42533.0.html' target='_blank'>คลิกเพื่อดู Document</a>
3. VRT Service: <a href='http://www.rd.go.th/publish/42534.0.html' target='_blank'>คลิกเพื่อดู Document</a>
4. VAT Service: <a href='http://www.rd.go.th/publish/42535.0.html' target='_blank'>คลิกเพื่อดู Document</a>
5. GEM Service: <a href='http://www.rd.go.th/publish/42532.0.html' target='_blank'>คลิกเพื่อดู Document</a>

# Branch

- master - .NET Core 2.2 (Legacy code)
- Development - .NET Core 3.1 and update response follow RESTful API

# Swagger Document

สามารถดูรายละเอียดต่างๆของ API โดย <a href='https://app.swaggerhub.com/apis-docs/sixnaskunz/RevenueDeptApi/v1' target='_blank'>คลิกที่นี่</a>

# Software Requirement

1. Visual Studio 2017 or later
2. .NET Core 2.2
3. .NET Core Runtime 2.2
4. Swashbuckle.AspNetCore v.4.0.1
5. System.ServiceModel.Http v.4.4.0
