# SamsungEncryptServer
server to handle encryption for H and J series Samsung TVs    
<br>
Currently only has step one.   
<br>
to call:    
http://localhost:57885/api/Step1    
with the json:
```
{
    "pin": "1234",
    "deviceId" : "12345"
}
```
<br>
Response:    

```
{
    "code": "0102000000000000000089000000053132333435047ADDE506183ADB04BDE849787B266F4CC54CE874E97F5A8B8E7EC88863233B7508F8D196727D137C1B9A7041D20003A8A132E7D1278F3C03AAD8C38251091C0913F35DD2D2B358933E71005E8CC40DC2DF1C3BA86189CE5038F180C97CA74EB40DF3B293CB3985219B6423B9F305343E1A22CCB438B6370E2311E01AB8DBB60000000000"
}
```
