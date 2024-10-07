from atraccion import Atraccion
from guardaparque import Guardaparque

class Parque:
    def __init__(self, nombre="Parque Desconocido", ubicacion="Ubicacion Desconocida", superficie=0.0):
        self.nombre = nombre
        self.ubicacion = ubicacion
        self.superficie = superficie
        self.atracciones = []
        self.guardaparques = []

    def agregar_atraccion(self, atraccion):
        self.atracciones.append(atraccion)

    def agregar_guardaparque(self, guardaparque):
        self.guardaparques.append(guardaparque)

    def __str__(self):
        return (f"Parque(Nombre={self.nombre}, Ubicacion={self.ubicacion}, Superficie={self.superficie}, "
                f"Atracciones={len(self.atracciones)}, Guardaparques={len(self.guardaparques)})")
