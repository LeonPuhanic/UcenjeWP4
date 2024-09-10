import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavBarAplikacija from './components/NavBarAplikacija'
import { RoutesNames } from './constants'
import Pocetna from './pages/Pocetna'
import OruzjePregled from './pages/Oruzja/OruzjePregled.jsx'

function App() {


  return (
    <>
      <NavBarAplikacija />
      <Routes>
        <Route path={RoutesNames.HOME} element={<Pocetna />} />

        <Route path={RoutesNames.ORUZJE_PREGLED} element={<OruzjePregled />} />
      </Routes>
    </>
  )
}

export default App
