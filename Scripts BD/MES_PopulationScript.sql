INSERT INTO TIPO_ESTADO 
VALUES  (DEFAULT,'Produccion'),
		(DEFAULT,'Fallo/Paro'),
		(DEFAULT,'Cafe'),
		(DEFAULT,'Almuerzo'),
		(DEFAULT,'Cena');

INSERT INTO TIPO_USUARIO
VALUES  (DEFAULT,'Operador'),
		(DEFAULT,'Supervisor'),
		(DEFAULT,'Tecnico');

INSERT INTO LINEA (ID, EstadoID)
VALUES  (DEFAULT,1),(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),
		(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),
		(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),
		(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),(DEFAULT,1),(DEFAULT,1);

INSERT INTO Producto (nombre, descripcion)
VALUES ('Limpiador Facial Suave', 'Limpiador facial suave y refrescante 150g'),
       ('Suero de Ácido Hialurónico', 'Suero de ácido hialurónico para hidratación 30mL'),
       ('Mascarilla de Arcilla Purificante', 'Mascarilla de arcilla para purificar la piel 100g'),
       ('Aceite de Rosa Mosqueta Puro', 'Aceite de rosa mosqueta prensado en frío 30mL'),
       ('Crema Corporal de Manteca de Karité', 'Crema corporal hidratante con manteca de karité 250mL'),
       ('Exfoliante Facial de Papaya', 'Exfoliante facial natural con extracto de papaya 150g'),
       ('Protector Solar SPF 30', 'Protector solar de amplio espectro SPF 30 100mL'),
       ('Crema Antiarrugas de Colágeno', 'Crema facial antienvejecimiento con colágeno 50mL'),
       ('Jabón de Manos de Coco', 'Jabón de manos suave con aroma a coco 250mL'),
       ('Aceite Esencial de Lavanda', 'Aceite esencial de lavanda puro 10mL');