import { Http, Response, Request } from'angular2/http';
import { Injectable } from 'angular2/core';
import { DataService } from './dataService';
import { Registration } from '../domain/registration';
import { User } from '../domain/user';

@Injectable()
export class MembershipService {
    private _accountRegisterAPI: string = 'api/account/register/';
    private _accountLoginAPI: string = 'api/account/authenticate/';
    private _accountLogoutAPI: string = 'api/account/logout/';

    constructor(public accountService: DataService) { }

    register(newUser: Registration) {
        this.accountService.set(this._accountRegisterAPI);
        return this.accountService.post(JSON.stringify(newUser));
    }

    login(credental: User) {
        this.accountService.set(this._accountLoginAPI);
        return this.accountService.post(JSON.stringify(credental));
    }

    logout() {
        this.accountService.set(this._accountLogoutAPI);
        return this.accountService.post(null, false);
    }

    isUserAuthenticated(): boolean {
        var user: User = localStorage.getItem('user');
        if (user != null) return true;
        return false;
    }

    getLoggedInUser(): User {
        var user: User;

        if (this.isUserAuthenticated()) {
            var userData = JSON.parse(localStorage.getItem('user'));
            user = new User(userData.Username, userData.Password);
        }

        return user;
    }
}