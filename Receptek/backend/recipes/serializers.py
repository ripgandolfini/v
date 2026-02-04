from rest_framework.serializers import ModelSerializer, SerializerMethodField

from .models import Recipe, Ingredient

class IngredientSerializer(ModelSerializer):
    class Meta:
        model = Ingredient
        fields = ["name"]

class RecipeSerializer(ModelSerializer):
    ingredients = SerializerMethodField()

    class Meta:
        model = Recipe
        fields = "__all__"

    def get_ingredients(self, obj):
        return [ingredient.name for ingredient in obj.ingredients.all()]