# RESTful API กรมสรรพากร / The Revenue Department Service
ระบบจัดการ Service ของกรมสรรพากร โดยใช้ RESTful API ในการเชื่อมต่อกับ SOAP Web Service และแปลงข้อมูลให้อยู่ในรูปแบบของ JSON โดยมี Swagger ใช้ในการทดสอบ

Document ของกรมสรรพากร: http://www.rd.go.th/publish/42545.0.html
API นี้จะประกอบไปด้วย Service ดังนี้ (รายละเอียดสามารถดูได้ตามลิงค์ที่แนบไว้)
1. Common Service: <a href='http://www.rd.go.th/publish/42539.0.html' />
2. TIN Service: http://www.rd.go.th/publish/42533.0.html
3. VRT Service: http://www.rd.go.th/publish/42534.0.html
4. VAT Service: http://www.rd.go.th/publish/42535.0.html
5. GEM Service: http://www.rd.go.th/publish/42532.0.html

# Swagger Document
สามารถดูรายละเอียดต่างๆของ API ได้จากลิงค์นี้ https://app.swaggerhub.com/apis-docs/sixnaskunz/RevenueDeptApi/v1

# Software Requirement
1. Visual Studio 2017 or later
2. .NET Core 2.2
3. .NET Core Runtime 2.2
4. Swashbuckle.AspNetCore v.4.0.1
5. System.ServiceModel.Http v.4.4.0
