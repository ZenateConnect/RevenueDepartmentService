วิธีการการ Add Trusted Root Certification Authorities
เบื้องต้นให้เราติดตั้ง Cer ทั้งสองตัวคือ adhq1.cer และ ADHQ5.cer ก่อน
ถ้าหากยังไม่สามารถเรียก API กรมสรรพากรได้ ให้ทำการ Add Certification ที่ชื่อ adhq1.cer เข้าไปที่ Trusted Root Certification Authorities ก่อน
จึงจะสามารถใช้งาน API ของทางกรมสรรพากรได้

ส่วนวิธี Add Trusted Root Certification Authorities สำหรับ Windows 10 นะครับ

1. เปิด Run > certlm.msc หรือ กด Start แล้ว Search พิมพ์ว่า "Certificates" แล้วเลือก Manage User Certificates
2. หาเมนูที่ชื่อ Trusted Root Certification Authorities > Certificates
3. คลิกขวาที่ Certificates เลือก Import และเลือกที่อยู่ของ adhq1.cer ตัวนี้