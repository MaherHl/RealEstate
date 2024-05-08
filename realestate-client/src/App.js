
import LandingPage from './Pages/LandingPage';
import SignUp from './Pages/SignUp';
import Login from './Pages/Login';
import Profile from './Pages/Profile';
import Dashboard from './Pages/Dashboard';
import AddForm from './Pages/AddForm';
import Appointement from './Pages/Appointement';
import Main from './Pages/Main';
import PropertyDetail from './Pages/PropertyDetail';
import Contact from './Pages/Contact';
import { BrowserRouter as Router, Route ,Routes } from 'react-router-dom';
import Edit from './Pages/Edit';

function App() {
  return (
  <>
  {/* <LandingPage/> */}
 {/*<SignUp/>*/}
 {/* <Login/>*/}
 {/*<Profile/>*/}
      {/* <Dashboard/> */}
    {/*<AddForm/>*/}
   { /*<Appointement/>*/}
   {/* <Main/> */}
   {/* <PropertyDetail/> */}
   {/* <Contact/> */}

   <Router>

      <Routes>

        <Route path="/" element={<LandingPage/>} />
        <Route path="/Signup" element={<SignUp/>} />
        <Route path="/contact" component={<Contact/>} />
        <Route path='/login' element={<Login/>}/>
        <Route path='/main' element = {<Main/>}/>
        <Route path="/dashboard" element={<Dashboard/>} />
        <Route path='/addFacility' element={<AddForm/>}/>
        <Route path='/Edit' element={<Edit/>}/>

    
      </Routes>
   </Router>
      

  
   
  </>
  );
}

export default App;
