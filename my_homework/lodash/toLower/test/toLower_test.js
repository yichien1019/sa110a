import { assertEquals } from "https://deno.land/std@0.63.0/testing/asserts.ts"
import * as _ from "../src/toLower.js"

Deno.test("toLower",() => {
    assertEquals(_.toLower('--Foo-Bar--'), --foo-bar--)
    assertEquals(_.toLower('fooBar'), foobar)
    assertEquals(_.toLower('__FOO_BAR__'), __foo_bar__)
})