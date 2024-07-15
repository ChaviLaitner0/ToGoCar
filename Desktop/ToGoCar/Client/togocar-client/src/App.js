// import React from 'react';
// import './App.css';
// import Register from './Components/Register/Register';
// import Login from './Components/Login/Login';

// function App() {
//     return (
//         <div className="App">
//             <div className="form-container">
//                 <Register />
//                 <Login />
//             </div>
//         </div>
//     );
// }

// export default App;

import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import './App.css';
import HomePage from './Components/HomePage/HomePage';
import Register from './Components/Register/Register';
import Login from './Components/Login/Login';
import Navbar from './Components/Navbar/Navbar';
import VehicleSelection from './Components/VehicleSelection/VehicleSelection';


function App() {
    return (
      
        <Router>
            <div className="app-background">
            <Navbar />
            <Routes>
                <Route exact path="/" element={<HomePage />} />
                <Route path="/login" element={<Login />} />
                <Route path="/register" element={<Register />} />
                <Route path="/vehicle-selection" element={<VehicleSelection />} />
            </Routes>
            </div>
        </Router>
    );
}

export default App;


// import React from 'react';
// import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
// import './App.css';
// import Register from './Components/Register/Register';
// import Login from './Components/Login/Login';
// import SubscriberComponent from './Components/Subscriber/SubscriberComponent';
// import CarComponent from './Components/Car/CarComponent';
// import VehicleSelection from './Components/VehicleSelection/VehicleSelection';

// function App() {
//     return (
//         <Router>
//             <div className="App">
//                 <Routes>
//                     <Route path="/login" element={<Login />} />
//                     <Route path="/register" element={<Register />} />
//                     <Route path="/subscribers" element={<SubscriberComponent />} />
//                     <Route path="/cars" element={<CarComponent />} />
//                     <Route path="/vehicle-selection" element={<VehicleSelection />} />
//                 </Routes>
//             </div>
//         </Router>
//     );
// }

// export default App;

