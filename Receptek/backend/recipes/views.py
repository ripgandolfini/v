from rest_framework.decorators import api_view
from rest_framework.response import Response
from .models import Recipe
from .serializers import RecipeSerializer

@api_view(["GET"])
def get_recipes(request):
    recipes = Recipe.objects.all()
    serialized = RecipeSerializer(recipes, many=True)
    return Response(serialized.data)