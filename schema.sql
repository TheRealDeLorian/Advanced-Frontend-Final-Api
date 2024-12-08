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

