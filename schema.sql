CREATE TABLE temple (
 id SERIAL PRIMARY KEY,
 templename text,
 lat text,
 long text,
 mailaddress text,
 photourl text
);

INSERT INTO temple (
 templename, lat, long, mailaddress, photourl
) VALUES
('Salt Lake City', 
'40.7704381',
'-111.8918202',
'50 N W Temple St, Salt Lake City, UT 84150', 
'https://cdn.britannica.com/90/175790-050-345E4C92/Brigham-Young-sculpture-Mormon-Temple-Salt-Lake-City-Utah.jpg?w=300'
),(
  'Oquirrh Mountain',
  '40.5510973',
  '-111.9874258',
  '11022 4000 W, South Jordan, UT 84009',
  'https://lh5.googleusercontent.com/p/AF1QipMOkzyhTD8ApCT-el7faWkvV3l63civD8z0siLb=w408-h272-k-no'
),(
  'Taylorsville',
  '40.6666244',
  '-111.9542623',
  '2603 W 4700 S, Salt Lake City, UT 84129',
  'https://lh5.googleusercontent.com/p/AF1QipOZ4KEWK8jg4zXrlJSfhrewAlWFbjBo1pOZZDtz=w426-h240-k-no'
),(
  'Provo City Center',
  '40.2338473',
  '-111.6585338',
  '50 S University Ave, Provo, UT 84601',
  'https://churchofjesuschristtemples.org/assets/provo-city-center-temple-59.jpg'
),(
  'Logan Utah',
  '41.7370274',
  '-111.8344828',
  '175 N 300 E, Logan, UT 84321',
  'https://churchofjesuschristtemples.org/assets/logan-temple-93.jpg'
),(
  'Manti Utah',
  '39.2659451',
  '-111.6387169',
  '200 E 510 N, Manti, UT 84642',
  'https://churchofjesuschristtemples.org/assets/manti-temple-83.jpg'
),(
  'St. George Utah',
  '37.1080813',
  '-113.5838728',
  '250 E 400 S, St. George, UT 84770',
  'https://churchofjesuschristtemples.org/assets/st-george-temple-68.jpg'
),(
  'Bountiful Utah',
  '40.8898982',
  '-111.8457405',
  '640 S Bountiful Blvd, Bountiful, UT 84010',
  'https://churchofjesuschristtemples.org/assets/bountiful-temple-71.jpg'
),(
  'Draper Utah',
  '40.5065384',
  '-111.8634495',
  '14065 S Canyon Vista Ln, Draper, UT 84020',
  'https://churchofjesuschristtemples.org/assets/draper-temple-69.jpg'
),(
  'Jordan River Utah',
  '40.5834542',
  '-111.9394629',
  '10200 S Temple Dr, South Jordan, UT 84095',
  'https://churchofjesuschristtemples.org/assets/jordan-river-temple-82.jpg'
),(
  'Brigham City Utah', 
'41.5036808',
'-112.0144864',
'250 S Main St, Brigham City, UT 84302', 
'https://churchofjesuschristtemples.org/assets/brigham-city-temple-70.jpg'
),(
  'Ogden Utah',
  '41.2236691',
  '-111.9732902',
  '350 22nd St, Ogden, UT 84401',
  'https://churchofjesuschristtemples.org/assets/ogden-temple-75.jpg'
),(
  'Mount Timpanogos Utah',
  '40.4082583',
  '-111.7924198',
  '742 N 900 E, American Fork, UT 84003',
  'https://churchofjesuschristtemples.org/assets/mount-timpanogos-temple-81.jpg'
),(
  'Cedar City Utah',
  '37.6776105',
  '-113.0618947',
  '280 S Cove Dr, Cedar City, UT 84720',
  'https://churchofjesuschristtemples.org/assets/cedar-city-temple-77.jpg'
),(
  'Payson Utah',
  '40.0318322',
  '-111.7384658',
  '1494 S 930 W, Payson, UT 84651',
  'https://churchofjesuschristtemples.org/assets/payson-temple-79.jpg'
),(
  'Tucson Arizona',
  '32.2763135',
  '-110.9399781',
  '7281 N Skyline Dr, Tucson, AZ 85718',
  'https://churchofjesuschristtemples.org/assets/tucson-temple-86.jpg'
),(
  'Gilbert Arizona',
  '33.2792962',
  '-111.7440697',
  '3301 S Greenfield Rd, Gilbert, AZ 85297',
  'https://churchofjesuschristtemples.org/assets/gilbert-temple-84.jpg'
),(
  'Phoenix Arizona',
  '33.6502545',
  '-112.1250197',
  '5220 W Pinnacle Peak Rd, Glendale, AZ 85310',
  'https://churchofjesuschristtemples.org/assets/phoenix-temple-85.jpg'
),(
  'Las Vegas Nevada',
  '36.2463347',
  '-115.2671621',
  '827 Temple View Dr, Las Vegas, NV 89110',
  'https://churchofjesuschristtemples.org/assets/las-vegas-temple-74.jpg'
),(
  'Los Angeles California',
  '34.0635422',
  '-118.4292467',
  '10777 Santa Monica Blvd, Los Angeles, CA 90025',
  'https://churchofjesuschristtemples.org/assets/los-angeles-temple-76.jpg'
),('San Diego California', 
'32.8774393',
'-117.2150949',
'7474 Charmant Dr, San Diego, CA 92122', 
'https://churchofjesuschristtemples.org/assets/san-diego-temple-89.jpg'
),(
  'Newport Beach California',
  '33.6244475',
  '-117.8565992',
  '2300 Bonita Canyon Dr, Newport Beach, CA 92660',
  'https://churchofjesuschristtemples.org/assets/newport-beach-temple-88.jpg'
),(
  'Sacramento California',
  '38.7608703',
  '-121.2625867',
  '2110 California Cir, Rancho Cordova, CA 95742',
  'https://churchofjesuschristtemples.org/assets/sacramento-temple-90.jpg'
),(
  'Portland Oregon',
  '45.4448594',
  '-122.7714863',
  '13600 Kruse Oaks Blvd, Lake Oswego, OR 97035',
  'https://churchofjesuschristtemples.org/assets/portland-temple-87.jpg'
),(
  'Seattle Washington',
  '47.6055247',
  '-122.2088703',
  '2808 148th Ave SE, Bellevue, WA 98007',
  'https://churchofjesuschristtemples.org/assets/seattle-temple-91.jpg'
),(
  'Boise Idaho',
  '43.5932686',
  '-116.2346684',
  '1211 S Cole Rd, Boise, ID 83709',
  'https://churchofjesuschristtemples.org/assets/boise-temple-72.jpg'
),(
  'Idaho Falls Idaho',
  '43.4746282',
  '-112.0355766',
  '1000 Memorial Dr, Idaho Falls, ID 83402',
  'https://churchofjesuschristtemples.org/assets/idaho-falls-temple-73.jpg'
),(
  'Rexburg Idaho',
  '43.8231095',
  '-111.7866404',
  '750 S 2nd E, Rexburg, ID 83440',
  'https://churchofjesuschristtemples.org/assets/rexburg-temple-92.jpg'
),(
  'Billings Montana',
  '45.7797591',
  '-108.5978267',
  '3100 Rim Point Dr, Billings, MT 59102',
  'https://churchofjesuschristtemples.org/assets/billings-temple-80.jpg'
),(
  'Denver Colorado',
  '39.5996213',
  '-104.9665125',
  '2001 E Phillips Cir, Centennial, CO 80122',
  'https://churchofjesuschristtemples.org/assets/denver-temple-78.jpg'
);


CREATE TABLE person (
 id SERIAL PRIMARY KEY,
 fname text,
 lname text,
 email text,
 pfpurl text
);

INSERT INTO person (
fname, lname, email, pfpurl) VALUES
('Dorian', 
'Cottle', 
'dorian.cottle@students.snow.edu', 
'https://lh3.googleusercontent.com/a/ACg8ocIKnjl0MKkMz17f9LmQov39RiZg_fWsu0eL0BVBbgzTkted8w6FBQ=s317-c-no'
);

CREATE TABLE visit (
  id SERIAL PRIMARY KEY,
  visittime TIMESTAMP,
  note text,
  personid INT,
  templeid INT,
  CONSTRAINT fk_temple FOREIGN KEY (templeid) REFERENCES temple (id) ON DELETE CASCADE,
  CONSTRAINT fk_person FOREIGN KEY (personid) REFERENCES person (id) ON DELETE CASCADE
);

INSERT INTO visit (
  visittime, note, personid, templeid
) VALUES (
  '2024-11-27 17:52:00', 
  'Went and felt the Spirit.',
  1,
  1
);

CREATE TABLE visit_photo (
  id SERIAL PRIMARY KEY,
  photourl text,
  visitid INT,
  CONSTRAINT fk_visit FOREIGN KEY (visitid) REFERENCES visit (id) ON DELETE CASCADE
);

INSERT INTO visit_photo (
  photourl, visitid
) VALUES (
'https://media.istockphoto.com/id/639496702/photo/smiling-businessman-in-front-of-church.jpg?s=612x612&w=0&k=20&c=XRfowcmEnT3YNmaQ6IZeOng8n7PA9n28DEd7uLienOg=',
1
);

