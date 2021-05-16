
create table cliente(
  cliente_id integer primary key autoincrement,
  nombre text,
  direccion text,
  telefono text,
  eliminado integer default 0,
  fecha_creacion datetime,
  fecha_modificacion datetime
);

create table producto(
    producto_id integer primary key autoincrement,
    producto text,
    valor integer,
    descripcion text,
    eliminado integer default 0,
    fecha_creacion datetime,
    fecha_modificacion datetime
);

create table pedido(
    pedido_id integer primary key autoincrement,
    cliente_id integer,
    domicilio integer,
    eliminado integer default 0,
    fecha_creacion datetime,
    fecha_modificacion datetime,
    foreign key (cliente_id) references cliente (cliente_id)
);

create table estado(
    estado_id integer primary key  autoincrement ,
    estado text,
    eliminado integer default 0,
    fecha_creacion datetime,
    fecha_modificacion datetime
);

create table estado_pedido(
    ep_id integer primary key autoincrement ,
    pedido_id integer,
    estado_id integer,
    activo boolean,
    fecha_creacion datetime,
    foreign key (pedido_id) references pedido (pedido_id),
    foreign key (estado_id) references estado (estado_id)
);
create table producto_pedido(
  pp_id integer primary key  autoincrement ,
  pedido_id integer,
  producto_id integer,
  cantidad integer,
  valor integer,
  fecha_creacion datetime,
  fecha_modificacion datetime,
  foreign key (pedido_id) references pedido (pedido_id),
  foreign key (producto_id) references producto (producto_id)
);

create table cuenta(
    cuenta_id integer  primary key  autoincrement ,
    cuenta text,
    eliminado integer default 0,
    fecha_creacion datetime,
    fecha_modificacion datetime
);
create table movimiento(
    movimiento_id integer  primary key  autoincrement ,
    tipo_movimiento text,
    cuenta_id integer,
    desripcion text,
    eliminado integer default 0,
    valor integer,
    pedido_id integer,
    fecha_movimiento datetime,
    fecha_creacion datetime,
    fecha_modificacion datetime,
    
    foreign key (cuenta_id) references cuenta (cuenta_id),
    foreign key (pedido_id) references pedido (pedido_id)
);

insert into estado (estado, fecha_creacion, fecha_modificacion) values ("RECIBIDO", current_date, current_date);
insert into estado (estado, fecha_creacion, fecha_modificacion) values ("ENTREGADO", current_date, current_date);
insert into estado (estado, fecha_creacion, fecha_modificacion) values("CANCELADO", current_date, current_date);
insert into estado (estado, fecha_creacion, fecha_modificacion) values ("EN PREPARACION", current_date, current_date);

insert into cliente (nombre, direccion, telefono, fecha_creacion, fecha_modificacion) values("BASE", null, "BASE", current_date,current_date);
insert into cuenta (cuenta, fecha_creacion, fecha_modificacion) values("NEQUI", current_date,current_date);
insert into cuenta (cuenta, fecha_creacion, fecha_modificacion) values("EFECTIVO", current_date,current_date);
