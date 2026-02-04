import React from 'react'
import { BASE_URL } from '../App'

const Recipe = (props) => {

  const {id, ingredients, name, category, image, description} = props

  return (
    <div>
        <img src={BASE_URL + image} />
        <h2>{name}</h2>
        
        <h3>Hozzávalók:</h3>
        <ul>
            { ingredients.map(hozzavalo => <li>{hozzavalo}</li>) }
        </ul>

        <h3>Elkészítés:</h3>
        <p>{description}</p>
    </div>
  )
}

export default Recipe