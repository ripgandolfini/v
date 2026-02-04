import React, { useEffect, useState } from 'react'
import Recipe from './components/Recipe'


export const BASE_URL = "http://127.0.0.1:8000"

const App = () => {

  const [receptek, setReceptek] = useState([])

  useEffect(()=>{
    fetch(BASE_URL + "/recipes/")
    .then((valasz)=>{ return valasz.json() })
    .then((receptek)=>{ setReceptek(receptek) })
  }, [])

  return (
    <div>
      {receptek.map(recept => <Recipe {...recept} />)}
    </div>
  )
}

export default App