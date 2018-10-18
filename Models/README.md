#clients (todos los clientes registrados en algún momento)
name (como se llama?)
phone_number (donde lo contacto?)
email (identificador y medio de contacto)

#cars: (todos los autos registrados por el admin)
model (que auto es?)
base_price (cual es el precio base?)
image (cual se llama la foto para encontrarla en la bd?)
index (cual quiero mostrar primero y cuál después?)

#dispatches (quien compró? y a que dirección)
client_id: (a quién se vendió)
dispatch_address: (a donde se entrega??)

#orders (que auto se vendió? cuando se vendió? a donde y a quién se vendió?)
car_id (que auto se vendió)
dispatch_id (a donde se entrega y a quién se vendió)
date (cuando se vendió)

#options (como es la parte del auto?)
code (el código de la opción)
price (el precio de la opción)
descripcion (black wheels)
image (la idea es que la parte (pintura, rueda, techo...) cambie en la imagen a medida que cambia la selección)

#partes (como está compuesto el auto escogido?)
order_id (a que orden o pedido corresponde esta parte?)
option_id (la configuracion de una de las partes del auto vendido)
