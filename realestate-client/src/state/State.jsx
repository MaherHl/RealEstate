import { createSlice } from "@reduxjs/toolkit";



const initialState = {
    user: null,
    token: null,
    Facilities: [],
    Appointements : []

}
export const authSlice = createSlice({

    name:'auth',
    initialState,
    reducers: {
            setLogin:(state,action)=>{
                state.user = action.payload.user;
                state.token = action.payload.token
            },
            setLogout:(state)=>{
                state.user=null
                state.token = null
            },
            setFacilities:(state,action)=>{
                state.Facilities = action.payload.Facilities
            },
            setAppointements :(state,action)=>{
                state.Appointements = action.payload.Appointements;

            },
        }
    })
    export const  {setLogin,setLogout,setFacilities,setAppointements}= authSlice.actions
    export default authSlice.reducer;