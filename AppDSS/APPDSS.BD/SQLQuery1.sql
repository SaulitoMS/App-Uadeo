Create database DB_DSS

use DB_DSS

Create table Proyecto(
ID_Proy int primary key,
Nombre_Proy char(50),
Objetivo_Proy char(200),
)

Create table Alternativas(
ID_Alt int primary key,
Nombre_Alt char(50),
Descripcion_Alt char(200),
ID_Proy int,
Foreign key (ID_Proy) references Proyecto(ID_Proy),
)

Create table Criterios(
ID_Crit int primary key,
Nombre_Crit char(50),
Descripcion_Crit char(200),
Peso_Crit int,
ID_Proy int,
Foreign key (ID_Proy) references Proyecto(ID_Proy),
)

Create table Matriz(
ID_Matriz int primary key,
Valor_Matriz int,
ID_Proy int,
ID_Alt int,
ID_Crit int,
Foreign key (ID_Proy) references Proyecto(ID_Proy),
Foreign key (ID_Alt) references Alternativas(ID_Alt),
Foreign key (ID_Crit) references Criterios(ID_Crit),
)

Create table Score(
ID_Score int primary key,
Score int,
ID_Proy int,
ID_Alt int,
Foreign key (ID_Proy) references Proyecto(ID_Proy),
Foreign key (ID_Alt) references Alternativas(ID_Alt),
)