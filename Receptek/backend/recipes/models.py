from django.db import models

class Ingredient(models.Model):
    name = models.CharField(max_length=255)

    def __str__(self):
        return self.name

class Recipe(models.Model):
    name = models.CharField(max_length=255)
    ingredients = models.ManyToManyField(Ingredient)
    category = models.CharField(choices=[
        ("main", "main"), 
        ("soup","soup"), 
        ("dessert", "dessert"),
        ("other", "other")])
    image = models.ImageField(null=True, blank=True, upload_to="images")
    description = models.TextField(null=True, blank=True)
    
    def __str__(self):
        return self.name