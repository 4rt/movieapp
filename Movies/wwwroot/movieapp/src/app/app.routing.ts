import { Routes } from '@angular/router';

import { HomeComponent } from './home-component/home.component'
import {DetailComponent } from './detail-component/detail.component'

export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'detail/:id', component: DetailComponent },
    /*{ path: 'register', component: RegisterUserComponent },
    { path: 'authenticated', component: AuthenticatedUserComponent, canActivate: [AuthGuard],
      children: [
        { path: '', canActivateChild: [AuthGuard],
          children: [
            { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
            { path: 'dashboard', component: DashboardComponent },
            { path: 'country-list/:count', component: CountryListComponent },
            { path: 'country-detail/:id/:operation', component: CountryDetailComponent },
            { path: 'country-maint', component: CountryMaintComponent },
            { path: 'settings', component: SettingsComponent },
          ] }
      ] },*/
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: '**', redirectTo: 'home', pathMatch: 'full' }
];