CREATE TABLE Temples (
 id SERIAL PRIMARY KEY,
 templename text,
 pluscode text,
 mailaddress text,
 photourl text
);

INSERT INTO Temples (
 templename, pluscode, mailaddress, photourl
) VALUES
('Salt Lake City', 
'Q4C5+66 Salt Lake City, Utah', 
'50 N W Temple St, Salt Lake City, UT 84150', 
'https://cdn.britannica.com/90/175790-050-345E4C92/Brigham-Young-sculpture-Mormon-Temple-Salt-Lake-City-Utah.jpg?w=300'
);

CREATE TABLE People (
 id SERIAL PRIMARY KEY,
 fname text,
 lname text,
 email text,
 pfpurl text
);

INSERT INTO People (
fname, lname, email, pfpurl) VALUES
('Dorian', 
'Cottle', 
'dorian.cottle@students.snow.edu', 
'https://lh3.googleusercontent.com/a/ACg8ocIKnjl0MKkMz17f9LmQov39RiZg_fWsu0eL0BVBbgzTkted8w6FBQ=s317-c-no'
);

CREATE TABLE Visits (
  id SERIAL PRIMARY KEY,
  visittime TIMESTAMP,
  note text,
  templeid INT,
  CONSTRAINT fk_temple FOREIGN KEY (templeid) REFERENCES Temples (id) ON DELETE CASCADE
);

INSERT INTO Visits (
  visittime, note, templeid
) VALUES (
  '2024-11-27 17:52:00', 
  'Went and felt the Spirit.',
  1
);

CREATE TABLE VisitPhotos (
  id SERIAL PRIMARY KEY,
  photourl text,
  visitid INT
);

INSERT INTO VisitPhotos (
  photourl, visitid
) VALUES (
'https://media.istockphoto.com/id/639496702/photo/smiling-businessman-in-front-of-church.jpg?s=612x612&w=0&k=20&c=XRfowcmEnT3YNmaQ6IZeOng8n7PA9n28DEd7uLienOg=',
1
);

