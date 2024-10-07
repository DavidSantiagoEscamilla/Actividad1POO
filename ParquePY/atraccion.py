class Atraccion:
    def __init__(self, nombre="Atracción Desconocida", tipo="Tipo Desconocido", precio=0.0):
        self.nombre = nombre
        self.tipo = tipo
        self.precio = precio

    def __str__(self):
        return f"Atraccion(Nombre={self.nombre}, Tipo={self.tipo}, Precio={self.precio})"
