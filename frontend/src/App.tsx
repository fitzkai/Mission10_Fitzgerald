import './App.css'
import BowlerList from './bowlerList'

function Header() 
{
  return (
    <>
      <h2>Bowler Information</h2>
      <p>Information about Bowlers from a Bowling League.</p>
      <p>These bowlers are from teams Marlins and Sharks.</p>
    </>
  )
}

function App() {

  return (
    <>
      <Header />
      <BowlerList/>
    </>
  )
}

export default App
