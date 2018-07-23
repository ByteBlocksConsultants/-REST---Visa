
##  <span style="color:#192D90">Visa Consumer Card Controls API </span> 
REST API connectiong to Visa's infrastructure, 
allowing a consumer to manage a Visa Credit Card in real time. 
 
Visa Consumer Transaction Controls lets cardholders defend against 
suspicious spend with the touch of a button.
 
## <span style="color:#192D90">Tech Stack Items </span> 

- .NET Core 2.0
-  C#
-  REST

 ## 
  
### <span style="color:#192D90"> Visa Transaction Controls APIs </span> 
  
##### Visa Transaction Controls
 
###### <span style="color:#9AA0BD">Enrollment Callback API </span> 
The Transaction Controls Client Host Callback API will be hosted external to Visa. Card Enrollment callback will be hosted by the authorizing agent.

######  <span style="color:#9AA0BD">Notification Delivery Callback API </span> 
The Transaction Controls Client Host Callback API will be hosted external to Visa. Alert notification callback will be hosted by the application serviceresponsible for delivering notifications to the consumer.

###### <span style="color:#9AA0BD">  Authorization API<span>
The Authorization Decision API enables an authorization processor to request an authorization decision recommendation based on cardholder rules configured in consumer transaction controls. In addition, the API enables the authorization processor to update an authorization decision with the actual decision that was rendered.

###### <span style="color:#9AA0BD"> Customer Alerts Preference API </span> 
The Customer Alerts Preference Management API enables consumers to establish a issuer centric profile with individual alert preferences for last mile alerts delivery. Customer profile is scoped at Issuer level. Once a profile have been created for a bank, then same can be used to configure alerts on different cards issued by same bank. This API only needs to be used if Issuer have enrolled in Visa last mile Alerts delivery.

###### <span style="color:#9AA0BD"> Program Administration API
The Transaction Controls Program Administration API enables Issuers to change program configurations for their sponsorID.

###### <span style="color:#9AA0BD"> Customer Rules API </span> 
  The Customer Rules API enables consumers to establish control rules that will define the type of transactions they want to Manage.
	

#### <span style="color:#192D90">Business Value </span> 

- At the touch of a button, cardholders can disable or enable the use of their card.
- Cardholders can closely monitor purchase transactions on their accounts with alerts.
- Scalable and flexible platform to conform to your business needs and timelines. 
 
#### <span style="color:#192D90">Control Flow </span> 

 ![](https://developer.visa.com/images2/products/visa_consumer_transaction_controls/visa_obo_flow.png)
 
## <span style="color:#192D90">Useful Resources </span>  
 
 - https://developer.visa.com
 - https://developer.visa.com/capabilities/vctc

 
## <span style="color:#192D90"> ByteBlocks Project Team Members </span> 
 
- Angelina Ilieva  https://github.com/angelinai
- Dessi Sinkwich   https://github.com/dsinkwich
   
 

  
 
  
   